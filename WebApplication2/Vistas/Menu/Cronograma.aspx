<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="Cronograma.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.Cronograma" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="https://cdn.alloyui.com/3.0.1/aui/aui-min.js"></script>
    <link href="https://cdn.alloyui.com/3.0.1/aui-css/css/bootstrap.min.css" rel="stylesheet"></link>
    <div id="wrapper">
        <div id="myScheduler"></div>
    </div>
    <script>
        YUI().use(
  'aui-scheduler',
  function (Y) {
      var events = [
        {
            
            content: '<%=drconsulta["nombre"].ToString().ToUpperInvariant() %>',
            endDate: new Date(2018, 1, 5, 23, 59),
            startDate: new Date(2018, 1, 5, 0)
        },
        {
            content: 'MultipleDays',
            endDate: new Date(2018, 1, 8),
            startDate: new Date(2018, 1, 4)
        },
        {
            content: 'Disabled',
            disabled: true,
            endDate: new Date(2018, 1, 8, 5),
            startDate: new Date(2018, 1, 8, 1)
        },
        {
            content: 'Meeting',
            endDate: new Date(2018, 1, 7, 7),
            meeting: true,
            startDate: new Date(2018, 1, 7, 3)
        },
        {
            color: '#88D',
            content: 'Overlap',
            endDate: new Date(2018, 1, 5, 4),
            startDate: new Date(2018, 1, 5, 1)
        },
        {
            content: 'Reminder',
            endDate: new Date(2018, 1, 4, 4),
            reminder: true,
            startDate: new Date(2018, 1, 4, 0)
        }
      ];

      var agendaView = new Y.SchedulerAgendaView();
      var dayView = new Y.SchedulerDayView();
      var eventRecorder = new Y.SchedulerEventRecorder();
      var monthView = new Y.SchedulerMonthView();
      var weekView = new Y.SchedulerWeekView();

      new Y.Scheduler(
        {
            activeView: weekView,
            boundingBox: '#myScheduler',
            date: new Date(2018, 5, 10),
            eventRecorder: eventRecorder,
            items: events,
            render: true,
            views: [dayView, weekView, monthView, agendaView]
        }
      );
  }
);
    </script>

</asp:Content>
