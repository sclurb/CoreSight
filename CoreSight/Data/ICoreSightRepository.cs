using CoreSight.Data.Entities;
using CoreSight.ViewModels;
using System;
using System.Collections.Generic;

namespace CoreSight.Data
{
    public interface ICoreSightRepository
    {
        void AddReading(Readings newReading);
        IEnumerable<Readings> GetAllReadings();
        public IEnumerable<Readings> GetReadingsByDateRange(ChartViewModel dates);
        bool SaveAll();
        bool SaveChanges();
       // void AddReading(Readings newReading);
    }
}