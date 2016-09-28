using JsonDataWithJqueryReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonDataWithJqueryReview.Controllers
{
    public class BlogController : Controller
    {
        private EFDataContext db;

        public BlogController()
        {
            db = new EFDataContext();
            //检测到循环引用可以加上这句
            db.Configuration.ProxyCreationEnabled = false;
        }
        public ActionResult Index()
        {
            //创建下拉框的方式二
            List<SelectListItem> categories = new List<SelectListItem>();
            //创建一个默认选项
            categories.Add(new SelectListItem() { Text = "--请选择--", Value = "0", Selected = true });
            //查询所有的分类
            var lstCategories = db.BlogCategories.ToList();

            //循环添加到下拉框中
            foreach (var item in lstCategories)
            {
                categories.Add(new SelectListItem()
                {
                    Text = item.CategoryName,
                    Value = item.CategoryId.ToString()
                });
            }

            ViewBag.CategoryList = categories;
            return View();
        }


        /// <summary>
        /// 根据产品分类找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult GetBlogByCategoryId(int id)
        {

            var data = db.Bolgs.Where(s => s.CategoryId == id).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);

        }
    }
}