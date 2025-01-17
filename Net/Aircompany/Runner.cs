﻿using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;

namespace Aircompany
{
    public class Runner
    {
        public static List<Plane> planes = new List<Plane>() {
            new PassengerPlane(new PlaneSpecification { Model = "Boeing-737", MaxSpeed = 900, MaxFlightDistance = 12000, MaxLoadCapacity = 60500 }, 164),
            new PassengerPlane(new PlaneSpecification { Model = "Boeing-737-800", MaxSpeed = 940, MaxFlightDistance = 12300, MaxLoadCapacity = 63870 }, 192),
            new PassengerPlane(new PlaneSpecification { Model = "Boeing-747", MaxSpeed = 980, MaxFlightDistance = 16100, MaxLoadCapacity = 70500 }, 242),
            new PassengerPlane(new PlaneSpecification { Model = "Airbus A320", MaxSpeed = 930, MaxFlightDistance = 11800, MaxLoadCapacity = 65500 }, 188),
            new PassengerPlane(new PlaneSpecification { Model = "Airbus A330", MaxSpeed = 990, MaxFlightDistance = 14800, MaxLoadCapacity = 80500 }, 222),
            new PassengerPlane(new PlaneSpecification { Model = "Embraer 190", MaxSpeed = 870, MaxFlightDistance = 8100, MaxLoadCapacity = 30800 }, 64),
            new PassengerPlane(new PlaneSpecification { Model = "Sukhoi Superjet 100", MaxSpeed = 870, MaxFlightDistance = 11500, MaxLoadCapacity = 50500 }, 140),
            new PassengerPlane(new PlaneSpecification { Model = "Bombardier CS300", MaxSpeed = 920, MaxFlightDistance = 11000, MaxLoadCapacity = 60700 }, 196),
            new MilitaryPlane(new PlaneSpecification { Model = "B-1B Lancer", MaxSpeed = 1050, MaxFlightDistance = 21000, MaxLoadCapacity = 80000 }, MilitaryType.BOMBER),
            new MilitaryPlane(new PlaneSpecification { Model = "B-2 Spirit", MaxSpeed = 1030, MaxFlightDistance = 22000, MaxLoadCapacity = 70000 }, MilitaryType.BOMBER),
            new MilitaryPlane(new PlaneSpecification { Model = "B-52 Stratofortress", MaxSpeed = 1000, MaxFlightDistance = 20000, MaxLoadCapacity = 80000 }, MilitaryType.BOMBER),
            new MilitaryPlane(new PlaneSpecification { Model = "F-15", MaxSpeed = 1500, MaxFlightDistance = 12000, MaxLoadCapacity = 10000 }, MilitaryType.FIGHTER),
            new MilitaryPlane(new PlaneSpecification { Model = "F-22", MaxSpeed = 1550, MaxFlightDistance = 13000, MaxLoadCapacity = 11000 }, MilitaryType.FIGHTER),
            new MilitaryPlane(new PlaneSpecification { Model = "C-130 Hercules", MaxSpeed = 650, MaxFlightDistance = 5000, MaxLoadCapacity = 110000 }, MilitaryType.TRANSPORT)
    };
        public static void Main(string[] args)
        {
            Airport airport = new Airport(planes);
            Airport militaryAirport = new Airport(airport.GetMilitaryPlanes());
            Airport passengerAirport = new Airport(airport.GetPassengersPlanes());
            Console.WriteLine(militaryAirport
                              .SortByMaxDistance()
                              .ToString());
            Console.WriteLine(passengerAirport
                              .SortByMaxSpeed()
                              .ToString());
            Console.WriteLine(passengerAirport.GetPassengerPlaneWithMaxPassengersCapacity());
        }
    }
}
