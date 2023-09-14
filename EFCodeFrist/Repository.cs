using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist
{
    public class Repository<IModel> where IModel : class
    {
        ModelDBContext Context = null;

        public Repository()
        {
            Context = new ModelDBContext();
        }

        private DbSet<IModel> EntitySet
        {
            get { return Context.Set<IModel>(); }
        }

        public IModel Create(IModel model)
        {
            EntitySet.Add(model);
            Context.SaveChanges();

            return model;
        }

        public IModel Update(IModel model)
        {
            EntitySet.Update(model);
            Context.SaveChanges();

            return model;
        }
        
        public List<IModel> GetAll()
        {
            var list = EntitySet.ToList();
            return list;
        }
        
        public IModel GetById(int id)
        {
            //EntitySet.Update(model);
          var model =  EntitySet.AsEnumerable().Where(s => s.GetType()
                                                .GetProperty("Id")
                                                .GetValue(s).ToString()==id.ToString()).FirstOrDefault();
            
            //Context.SaveChanges();

            return model;
        }

        public bool Delete(IModel reg)
        {
            bool Result = false;
            try
            {
                var opj = reg.GetType();
                opj.GetProperty("IsDeleted").SetValue(reg, true);
                EntitySet.Update(reg);

                Context.SaveChanges();

                return Result;
            }
            catch (Exception exception)
            {
               // ProjectData.SetProjectError(exception);
               Console.WriteLine(exception.Message+""+exception.InnerException.Message);
               // Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
                //ProjectData.ClearProjectError();
                return false;
            }
        }

    }
}
