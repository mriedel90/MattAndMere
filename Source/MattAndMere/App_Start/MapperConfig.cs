using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MattAndMere.Entities;
using MattAndMere.Models;

namespace MattAndMere.App_Start
{
    public class MapperConfig
    {
        public static void ConfigureMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ReservationModel, Reservation>();
                cfg.CreateMap<Reservation, ReservationModel>();
            });
        }
    }
}