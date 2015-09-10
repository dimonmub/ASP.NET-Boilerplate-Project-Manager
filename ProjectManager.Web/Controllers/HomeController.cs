using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Collections;

namespace ProjectManager.Web.Controllers
{
    public class HomeController : ProjectManagerControllerBase
    {
        ProjectManagerEntities db = new ProjectManagerEntities();
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }

        public JsonResult Projects()
        {
            var projects = db.PJ_PROJECT.ToArray();
            return Json(projects, JsonRequestBehavior.AllowGet);            
        }

        public JsonResult Tasks(string id)
        {
            decimal num = 0;
            var projects = db.PJ_PROJECT.ToArray();
            foreach (PJ_PROJECT project in projects)
                if (project.ID.Equals(Convert.ToDecimal(id)))
                    num = Convert.ToInt64(project.OBJECT_ID);            
            List<PJ_TASK> relevantTasks = new List<PJ_TASK>();            
            var tasks = db.PJ_TASK.ToArray();
            foreach (PJ_TASK task in tasks)
                if (task.PJ_ID == num)
                    relevantTasks.Add(task);
            return Json(relevantTasks, JsonRequestBehavior.AllowGet);
            /*var allTasks = db.PJ_TASK.ToArray();
            var tasks = new PJ_TASK[10];
            for (int i = 0; i < 10; i++)
                tasks[i] = allTasks[i];
            return Json(tasks, JsonRequestBehavior.AllowGet);*/
        }

        public JsonResult getProjectById(string id)
        {
            long num = 0;
            PJ_PROJECT project = null;
            var customers = db.PJ_CUSTOMER.ToArray();
            var employees = db.PJ_EMP.ToArray();
            if (id != "null")
            {
                num = Convert.ToInt64(id);
                project = db.PJ_PROJECT.Find(num);
            }
            foreach(var cust in customers)
            {
                if (cust.OBJECT_ID == project.CUST_ID)
                    project.LBL = cust.NAME;
            }
            foreach(var emp in employees)
            {
                if (emp.OBJECT_ID == project.AUTHOR_ID)
                    project.DESCRIPTION = emp.FIRST_NAME + ' ' + emp.LAST_NAME;
                if (emp.OBJECT_ID == project.MAN_ID)
                    project.NOTE = emp.FIRST_NAME + ' ' + emp.LAST_NAME;
            }
            return Json(project, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getTaskById(string id)
        {
            long num = 0;
            var employees = db.PJ_EMP.ToArray();
            PJ_TASK task = null;
            num = Convert.ToInt64(id);
            task = db.PJ_TASK.Find(num);
            foreach (var emp in employees)
            {
                if (emp.OBJECT_ID == task.EXEC_ID)
                    task.DESCRIPTION = emp.FIRST_NAME + ' ' + emp.LAST_NAME;
                if (emp.OBJECT_ID == task.RESOURCE_MAN_ID)
                    task.NOTE = emp.FIRST_NAME + ' ' + emp.LAST_NAME;
            }
            return Json(task, JsonRequestBehavior.AllowGet);
        }
	}
}