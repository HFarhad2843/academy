﻿using System.ComponentModel;

namespace Academy.DataAccess.Contexts;

public static class AcademyDbContext
{
    public static List <Group> Groups { get; set; }
    public static List <Category> Categories{ get; set; }
    public static List <Student> Students { get; set; }
}
