﻿using System.Collections.Generic;
using System.Linq;
using SystemForOrderingTickets.Models;
using SystemForOrderingTickets.Services;

namespace SystemForOrderingTickets.Repositories
{
    public class CategoriesRepository
    {
        private static List<Category> Categories;

        public CategoriesRepository(string categoriesPath)
        {
            if (Categories == null)
            {
                var xmlService = new XMLReaderService();
                Categories = xmlService.ReadXMLFile<Category>(categoriesPath).ToList();
            }
        }

        public Category Get(int categoryId)
        {
            return Categories.FirstOrDefault(q => q.Id == categoryId);
        }

        public List<Category> GetCategories()
        {
            return Categories.ToList();
        }
    }
}