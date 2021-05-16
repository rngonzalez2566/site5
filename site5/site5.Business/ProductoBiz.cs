using site5.site5.Data.Services;
using site5.site5.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site5.site5.Business
{
    public class ProductoBiz
    {

        public void Agregar(Productos model)
        {
            var db = new BaseDataService<Productos>();
            db.Create(model);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Productos> Listar()
        {
            var db = new BaseDataService<Productos>();
            var lista = db.Get();
            return lista;
        }

        public Productos Get(int id)
        {
            var db = new BaseDataService<Productos>();
            return db.GetById(id);
        }

        public void Eliminar(Productos model)
        {
            var db = new BaseDataService<Productos>();
            db.Delete(model);
        }

        public void Update(Productos model)
        {
            var db = new BaseDataService<Productos>();
            db.Update(model);
        }
    }
}