using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            DevExpress.Persistent.BaseImpl.Event obj = new DevExpress.Persistent.BaseImpl.Event(Session);
            obj.Subject = "Test Event";
            obj.StartOn = DateTime.Now;
            obj.AllDay = true;
            obj.Save();
        }
    }
}
