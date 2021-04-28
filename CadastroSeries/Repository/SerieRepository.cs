using CadastroSeries.Interfaces;
using CadastroSeries.Models;
using System.Collections.Generic;

namespace CadastroSeries.Repository
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Delete(int id)
        {
            listaSerie[id].Excluir();
        }

        public Serie GetById(int id)
        {
            return listaSerie[id];
        }

        public void Insert(Serie serie)
        {
            listaSerie.Add(serie);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int NextId()
        {
            return listaSerie.Count;
        }

        public void Update(int id, Serie serie)
        {
            listaSerie[id] = serie;
        }
    }
}
