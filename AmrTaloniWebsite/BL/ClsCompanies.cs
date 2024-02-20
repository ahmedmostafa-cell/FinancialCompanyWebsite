using AmrTaloniWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmrTaloniWebsite.BL
{
    public interface companyImageService
    {
        List<TbCompany> getAll();
        bool Add(TbCompany company);
        bool Edit(TbCompany company);
        bool Delete(TbCompany company);


    }


    public class ClsCompanies : companyImageService
        {
            AmrTaloniDatabaseContext ctx;
            public ClsCompanies(AmrTaloniDatabaseContext context)
            {
                ctx = context;
            }

            public List<TbCompany> getAll()
            {
                //_4ZsoftwareCompanyTestTaskContext o_4ZsoftwareCompanyTestTaskContext = new _4ZsoftwareCompanyTestTaskContext();
                List<TbCompany> lstItemImages = ctx.TbCompanies.ToList();

                return lstItemImages;
            }

            public bool Add(TbCompany itemImage)
            {
                try
                {
                    //_4ZsoftwareCompanyTestTaskContext o_4ZsoftwareCompanyTestTaskContext = new _4ZsoftwareCompanyTestTaskContext();
                    ctx.TbCompanies.Add(itemImage);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;

                }
            }
            public bool Edit(TbCompany itemImage)
            {
                try
                {
                    //_4ZsoftwareCompanyTestTaskContext o_4ZsoftwareCompanyTestTaskContext = new _4ZsoftwareCompanyTestTaskContext();

                    ctx.Entry(itemImage).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;

                }
            }

            public bool Delete(TbCompany itemImage)
            {
                try
                {
                    //_4ZsoftwareCompanyTestTaskContext o_4ZsoftwareCompanyTestTaskContext = new _4ZsoftwareCompanyTestTaskContext();

                    ctx.Entry(itemImage).State = EntityState.Deleted;
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;

                }
            }
        }
    }

