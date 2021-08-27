<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128590738/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2082)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [SchedulerListViewViewController.cs](./CS/WinSolution.Module.Win/SchedulerListViewViewController.cs) (VB: [SchedulerListViewViewController.vb](./VB/WinSolution.Module.Win/SchedulerListViewViewController.vb))
<!-- default file list end -->
# How to get Event object by the scheduler's Appointment object


<p>This example demonstrates how to use the utilities of the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2812">Scheduler module</a> to get a particular IEvent persistent object by the scheduler's Appointment. The main work is done by the SchedulerListEditorBase.SourceObjectHelper.GetSourceObject method.<br />
This can be helpful, for example, when you want to provide a custom display text to appointments in the scheduler control, based on the logic of your persistent IEvent class. For example, you may have a custom IEvent implementation (see the <a href="https://www.devexpress.com/Support/Center/p/E1255">How to create fully custom Role, User, Event, Resource classes for use with the Security and Scheduler modules</a> example for more information) having a reference to a Customer object, And you want to display customer's information in the scheduler. This can be done by handling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_InitAppointmentDisplayTexttopic">SchedulerControl.InitAppointmentDisplayText</a> event as shown in this example.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2814">How to: Access the Scheduler Control</a></p>

<br/>


