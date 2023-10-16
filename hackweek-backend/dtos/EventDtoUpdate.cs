﻿namespace hackweek_backend.Models
{
    public class EventDtoUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; }
        public bool IsPublic { get; set; }
    }
}
