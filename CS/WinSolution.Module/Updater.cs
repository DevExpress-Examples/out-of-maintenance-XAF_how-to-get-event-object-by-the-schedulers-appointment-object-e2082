using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp;

namespace WinSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            DevExpress.Persistent.BaseImpl.Event obj = ObjectSpace.CreateObject<DevExpress.Persistent.BaseImpl.Event>();
            obj.Subject = "Test Event";
            obj.StartOn = DateTime.Now;
            obj.AllDay = true;
            obj.Save();
        }
    }
}
