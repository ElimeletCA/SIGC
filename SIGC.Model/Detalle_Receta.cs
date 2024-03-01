using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Detalle_Receta
    {
        private int _id_detalle_receta;
        private int _id_receta;
        private int _id_medicamento;
        private int _cantidad;
        private string _duracion_tratamiento;
        private string _nota;

        public int Id_detalle_receta
        {
            get { return _id_detalle_receta; }
            set { Id_detalle_receta = value; }
        }

        public int Id_receta
        {
            get { return _id_receta; }
            set { _id_receta = value; }
        }

        public int Id_medicamento
        {
            get { return _id_medicamento; }
            set { _id_medicamento = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public string Duracion_tratamiento
        {
            get { return _duracion_tratamiento; }
            set { _duracion_tratamiento = value; }
        }

        public string Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public Detalle_Receta(int id_detalle_receta, int id_receta, int id_medicamento, int cantidad, string duracion_tratamiento, string nota)
        {
            _id_detalle_receta = id_detalle_receta;
            _id_receta = id_receta;
            _id_medicamento = id_medicamento;
            _cantidad = cantidad;
            _duracion_tratamiento = duracion_tratamiento;
            _nota = nota;
        }
    }
}
