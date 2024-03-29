﻿using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Car : BaseEntity<int>
{
    public int ModelId { get; set; }
    public int ModelYear { get; set; }
    public string Plate { get; set; }
    public int State { get; set; } 
    public double DailyPrice { get; set; }

    public Model Model { get; set; }

    public Car()
    {

    }

    public Car(int id, int modelId, int modelYear,
        string plate, int state, double dailyPrice) : this()
    {
        Id = id;
        ModelId = modelId;
        ModelYear = modelYear;
        Plate = plate;
        State = state;
        DailyPrice = dailyPrice;
    }
}