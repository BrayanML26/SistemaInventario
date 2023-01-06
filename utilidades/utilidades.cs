using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace utilidades
{
    public class utilidad
    {

        public static void CreaArchivo(string nombre, string contenido)
        {
            //e/s
            if (System.IO.File.Exists(nombre))
                System.IO.File.Delete(nombre);

            System.IO.File.WriteAllText(nombre, contenido);

        }
        public static string LeerArchivo(string nombre)
        {
            if (System.IO.File.Exists(nombre))
                return System.IO.File.ReadAllText(nombre);
            
            return "";

        }

        public static DataSet ejecuta(string cmd)
        {

            DataSet dsPubs = new DataSet();
            try
            {
                SqlConnection objConn = new SqlConnection("Server=(local);Database=inventario;Trusted_Connection=True;");
                objConn.Open();

                SqlDataAdapter daAuthors = new SqlDataAdapter(cmd, objConn);
                daAuthors.Fill(dsPubs);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error de comunicacion");
                utilidad.CreaArchivo("ErrorDelSistema.hs", cmd+"\n"+ex.ToString());
            }
            return dsPubs;

        }

        public static bool ValidaForm(Control control, ErrorProvider er)
        {
            //if (utilidad.ValidaForm(this, errorProvider1))  return;
            bool conerror = false;
            foreach (Control item in control.Controls)
            {
                if (item.Controls.Count > 0) //recursivo
                {
                   bool conerror2= ValidaForm(item, er);
                    if (conerror2 == true)
                        conerror = true;
                }
                if (item is utilidades.textbox)
                {
                    utilidades.textbox obj = (utilidades.textbox)item;
                    
                    if (obj.Validar == true)
                    {
                        er.SetError(obj, (string.IsNullOrEmpty(obj.Text.Trim())) ? "Campo obligatorio" : "");
                        /*
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                            er.SetError(obj, "Campo obligatorio");
                        else
                            er.SetError(obj, "");*/
                        
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                            conerror = true;
                    }
                }
            }
            return conerror;
        }

        /// <summary>
        /// Determina sin el dataset posee datos
        /// </summary>
        /// <param name="dsdatos"></param>
        /// <returns></returns>
        public static Boolean dsTieneDatos(DataSet dsdatos)
        {
            return dsTieneDatos(dsdatos, false);
        }

        public static Boolean dsTieneDatos(DataSet dsdatos, bool SoloUna)
        {
            if (dsdatos == null || dsdatos.IsInitialized == false)
                return false;

            try
            {
                if (dsdatos.Tables.Count == 0)
                    return false;

                if (dsdatos.Tables[0].Rows.Count > 0)
                    return true;

                if (SoloUna)        // solo hace validacion en la primera tabla
                    return false;

                for (int i = 0; i < dsdatos.Tables.Count; i++)
                {
                    if (dsdatos.Tables[i].Rows.Count > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public static Boolean dsTieneDatos(DataTable dtdatos)
        {
            try
            {
                if (dtdatos.Rows.Count > 0)
                    return true;

            }
            catch { }
            return false;

        }

        public static Boolean dsTieneDatos(DataView dtdatos)
        {
            try
            {
                if (dtdatos.Table.Rows.Count > 0)
                    return true;

            }
            catch { }
            return false;

        }


       
    }
}
