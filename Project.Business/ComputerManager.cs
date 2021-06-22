using Proje.Entity.Entities;
using Project.Business.Utilities;
using Project.DataAccess.EfDals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business
{
    // This Class Makes Control parameters
    public class ComputerManager
    {

        // This Controller is taking Computer List 
        public List<Computer> GetAll()
        {
            EfComputerDal efdal = new EfComputerDal();
            var result = efdal.GetComp();
            return result;
        }
        // This Controller is taking one Computer with Id
        public Computer GetCompControlManager(int id)
        {
            EfComputerDal efcomp = new EfComputerDal();
            var result=efcomp.GetCompById(id);
            return result;
        }

        // This Controller is Deleting Computer with Id, If Id exist 
        public string DeleteControlManager(int id)
        {
            EfComputerDal efcomp = new EfComputerDal();
            var result = efcomp.GetCompById(id);
            Messages messages = new Messages();
            if (result == null)
            {
                return messages.NotFound;
            }
            else
            {
                efcomp.DeleteComp(id);
                return messages.Deleted;
            }
        }


        // This Controller is Updating one Computer to database 
        public string UpdateControlManager(Computer comp)
        {
            EfComputerDal efcomp = new EfComputerDal();
            var result =efcomp.GetCompById(comp.Id);
            Messages messages = new Messages();
            if (result ==null)
            {
                return messages.NotFound;
            }
            else
            {
                if (comp.Model==string.Empty)
                {
                    comp.Model = result.Model;
                }
                if (comp.Particular==string.Empty)
                {
                    comp.Particular = result.Particular;
                }
                if (comp.Total.ToString()==string.Empty)
                {
                    comp.Total = result.Total;
                }
                efcomp.UpdateComp(comp);
                return messages.Updated;
            }
        }


        // This Controller is Adding Computer to database If Parameters not null 
        public string AddControlManager(Computer comp)
        {
            Messages messages = new Messages();
            if (comp.Model!=string.Empty && comp.Particular != string.Empty && comp.Total >0)
            {
                EfComputerDal efdal = new EfComputerDal();
                efdal.ComputerAdd(comp);
                return messages.ProveMessage;
            }
            else
            {
               
                return messages.NotAllowMessage;
            }

        }
    }
}
