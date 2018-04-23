using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Scheduler.Win;
using DevExpress.XtraScheduler;

namespace WinSolution.Module.Win {
    public class SchedulerListViewViewController : ViewController<ListView> {
        private SchedulerListEditor listEditor;
        public SchedulerListViewViewController() {
            TargetObjectType = typeof(DevExpress.Persistent.BaseImpl.Event);
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            listEditor = View.Editor as SchedulerListEditor;
            if (listEditor != null) {
                SchedulerControl scheduler = (SchedulerControl)listEditor.SchedulerControl;
                scheduler.InitAppointmentDisplayText -= scheduler_InitAppointmentDisplayText;
                scheduler.InitAppointmentDisplayText += scheduler_InitAppointmentDisplayText;
            }
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            if (listEditor != null && listEditor.SchedulerControl != null) {
                SchedulerControl scheduler = (SchedulerControl)listEditor.SchedulerControl;
                scheduler.InitAppointmentDisplayText -= scheduler_InitAppointmentDisplayText;
            }
        }
        private void scheduler_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e) {
            Appointment appointment = e.Appointment;
            if (appointment.IsRecurring)
                appointment = e.Appointment.RecurrencePattern;
            DevExpress.Persistent.Base.General.IEvent obj = (DevExpress.Persistent.Base.General.IEvent)listEditor.SourceObjectHelper.GetSourceObject(appointment);
            e.Text = string.Format("{0}-({1})", e.Text, obj.GetHashCode());
        }
    }
}