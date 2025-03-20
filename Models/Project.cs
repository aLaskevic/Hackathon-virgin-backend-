namespace WebApplication3.Models;

public class Project
{
        public int Id { get; set; }
        public string VirginCompany { get; set; }
        public string Initiative { get; set; }
        public string Challenge { get; set; }
        public string WhatVirginIsDoing { get; set; }
        public List<CallToAction> CallToActions { get; set; }
        public List<string> Links { get; set; }
        
        public DateTime PublishDate { get; set; }
        
        public string ImageLink { get; set; }
    
}