using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YarnCodeFirst.Models;
using YarnCodeFirst.Data;

namespace YarnCodeFirst.Source
{
    public class CRUD
    {
        public void AddRecord(Yarn yarn)
        {
            Records.yarnContext.Yarns.Add(yarn);
            Records.yarnContext.SaveChanges();
        }

        public void DeleteRecord(int eid)
        {
            var emp = Records.yarnContext.Yarns.Find(eid);
            if(emp != null)
            {
                Records.yarnContext.Yarns.Remove(emp);
            }

            Records.yarnContext.SaveChanges();
        }

        public void UpdateRecord(int id, Yarn yarn)
        {
            var yFound = Records.yarnContext.Yarns.Find(id);
            if(yFound != null)
            {
                yFound.Yards = yarn.Yards;
                yFound.weight = yarn.weight;
                yFound.ManufacturerID = yarn.ManufacturerID;
                yFound.YarnId = yarn.YarnId;

                Records.yarnContext.SaveChanges();
            }      
        }

        public int GetMaxId()
        {
            return Records.yarnContext.Yarns.Max<Yarn>(yarn => yarn.YarnId);
        }

        public ICollection<Yarn> GetYarn()
        {
            return Records.yarnContext.Yarns.ToList();
        }
    }
}
