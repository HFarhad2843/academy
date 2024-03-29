﻿using Academy.Core.Entities;

namespace AcademyDataAccess.Contexts;

public static class AcademyDbContext
{
    public static List <Group> Groups { get; set; }
    public static List <Category> Categories { get; set; }
    public static List <Student> Students { get; set; } 
}
