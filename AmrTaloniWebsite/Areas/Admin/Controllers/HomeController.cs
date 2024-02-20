using AmrTaloniWebsite.BL;
using AmrTaloniWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AmrTaloniWebsite.Area.Admin.Controllers
{
    [Area("Admin")]

    

    public class HomeController : Controller
    {
        companyImageService compamyService;
        AmrTaloniDatabaseContext ctx;
        public HomeController(companyImageService Compamyservice , AmrTaloniDatabaseContext context )
        {
            compamyService = Compamyservice;
            ctx = context;

        }
        public IActionResult Index()
        {
            HomePageModel model = new HomePageModel();
            model.lstItems = compamyService.getAll();
            return View(model);
        }
        public async Task<IActionResult> Save(TbCompany ITEM, int id, List<IFormFile> files)
        {

            //_4ZsoftwareCompanyTestTaskContext o_4ZsoftwareCompanyTestTaskContext = new _4ZsoftwareCompanyTestTaskContext();

            //ClsItems oClsItems = new ClsItems();

            TbCompany oldItem = new TbCompany();
            //oldItem = ctx.TbCompanies.Where(a => a.CompanyId == id).FirstOrDefault();
            if (ITEM.CompanyId!= 0)
            {
               
               
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        string ImageName = Guid.NewGuid().ToString() + ".jpg";
                        var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", ImageName);
                        using (var stream = System.IO.File.Create(filePaths))
                        {
                            await file.CopyToAsync(stream);
                        }
                        ITEM.CompanyImageName = ImageName;
                    }
                }
                //oldItem.CompanyDescription = ITEM.CompanyDescription;
                //oldItem.CompanyImageName = ITEM.CompanyImageName;
                
                compamyService.Edit(ITEM);
            }
            else
            {
              
                
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        string ImageName = Guid.NewGuid().ToString() + ".jpg";
                        var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", ImageName);
                        using (var stream = System.IO.File.Create(filePaths))
                        {
                            await file.CopyToAsync(stream);
                        }
                        ITEM.CompanyImageName = ImageName;
                    }
                }

              

                compamyService.Add(ITEM);

            }


            HomePageModel model = new HomePageModel();
            model.lstItems = compamyService.getAll();
          

            return View("Index", model);
        }

        public IActionResult Delete(int id)
        {
          
            TbCompany oldItem = ctx.TbCompanies.Where(a => a.CompanyId == id).FirstOrDefault();
          
            compamyService.Delete(oldItem);

            HomePageModel model = new HomePageModel();
            model.lstItems = compamyService.getAll();


            return View("Index", model);


          
        }
        public IActionResult Form(int id)
        {
            HomePageModel model = new HomePageModel();
            model.item = ctx.TbCompanies.Where(a => a.CompanyId == id).FirstOrDefault();

            return View(model);
        }
    }
}
