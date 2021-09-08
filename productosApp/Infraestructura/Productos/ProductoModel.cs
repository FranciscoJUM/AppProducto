using Dominio.Emptties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
   public class ProductoModel
    {
        private Producto[] productos;
        public void Add(Producto p)
        {
            Add(p, ref productos);
        }
        public int Update(Producto a)
        {
            int index = GetIndexbycodigo(a);
            if (index < 0)
            {
                throw new ArgumentException(" no se encontro el producto");
            }
            else
            {
                productos[index] = a;
                return -1;
            }
        }
        public Producto[] Delete(Producto c)
        {
            int index = GetIndexbycodigo(c);
            if (index < 0)
            {
                throw new ArgumentException(" no se encontro el producto");
            }
            if(index != productos.Length)
                {
                productos[index] = productos[productos.Length - 1];
            }
               
            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            return tmp;
        }
        /* imcompleto public void GetProductoById()
        { }*/
        public Producto[] GetAll()
        {

            return productos;
        }


       
        
        
        
        
        
        
        
        
        
        
        
        
        // metodos privados

        private void Add(Producto e, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = e;
                return;
            }

            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp,pds.Length);

        }
    private int GetIndexbycodigo(Producto p)
        {
            int index = int.MinValue;

            if (p == null)
            {
                throw new ArgumentException(" no puede ser null");
            }
            if (productos == null)
            {
                return index;
            }
            int i = 0;
            foreach (Producto s in productos)
            {
                if( s.ID == p.ID)
                {
                    index = i;
                    break;
                    
                }
                i++;
            }
            return index;



                }
     


        
    }
}
