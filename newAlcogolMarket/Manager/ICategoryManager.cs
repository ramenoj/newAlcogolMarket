﻿using newAlcogolMarket.Models.Alcogol;

namespace newAlcogolMarket.Manager
{

    public interface ICategoryManager
    {

        Task<IList<CategoryofAlcogol>> GetAll();
        Task Create(string Name);
        Task Delete(int Id);

    }
}

