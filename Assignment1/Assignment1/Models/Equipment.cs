﻿namespace Assignment1.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public EquipmentType Type { get; set; }
        public string? Description { get; set; }
        public bool Availability { get; set; }
    }

}
