using System;
using System.Collections.Generic;
using gustavoakira.series.Interfaces;
using gustavoakira.series.Model;

namespace gustavoakira.series.Repository{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> series = new List<Serie>();
        public void Exclude(int id)
        {
            series[id].Remove();
        }

        public Serie FinById(int id)
        {
            return series[id];
        }

        public List<Serie> FindAll()
        {
            return series;
        }

        public void Insert(Serie entity)
        {
            series.Add(entity);
        }

        public int NextId()
        {
            return series.Count;
        }

        public void Update(int id, Serie entity)
        {
            series[id] = entity;
        }
    }
}