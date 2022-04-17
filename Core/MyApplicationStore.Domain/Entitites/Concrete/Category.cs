﻿using MyApplicationStore.Domain.Entitites.Abstract;

namespace MyApplicationStore.Domain.Entitites.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsApproved { get; set; }
    }
}
