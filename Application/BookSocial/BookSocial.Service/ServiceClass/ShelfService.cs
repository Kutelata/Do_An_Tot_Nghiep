﻿using System.Net.Http.Json;
using BookSocial.EntityClass.DTO;
using BookSocial.EntityClass.Entity;
using BookSocial.Service.ServiceInterface;

namespace BookSocial.Service.ServiceClass
{
    public class ShelfService : ConnectApi, IShelfService
    {
        public async Task<int> Create(Shelf shelf)
        {
            var response = await GetClient().PostAsJsonAsync($"Shelf/Create", shelf);
            var data = response.IsSuccessStatusCode ? 1 : 0;
            return data;
        }

        public async Task<int> DeleteByBookAndUserId(int bookId, int userId)
        {
            var response = await GetClient().DeleteAsync($"Shelf/DeleteByBookAndUserId?bookId={bookId}&userId={userId}");
            var data = response.IsSuccessStatusCode ? 1 : 0;
            return data;
        }

        public async Task<Shelf> GetByBookAndUserId(int bookId, int userId)
        {
            var response = await GetClient().GetAsync($"Shelf/GetByBookAndUserId?bookId={bookId}&userId={userId}");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<Shelf>() : null;
            return data;
        }

        public async Task<IEnumerable<Shelf>> GetByBookId(int bookId)
        {
            var response = await GetClient().GetAsync($"Shelf/GetByBookId?bookId={bookId}");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<IEnumerable<Shelf>>() : null;
            return data;
        }

        public async Task<IEnumerable<ShelfDetail>> GetByShelfDetail(int userId)
        {
            var response = await GetClient().GetAsync($"Shelf/GetByShelfDetail?userId={userId}");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<IEnumerable<ShelfDetail>>() : null;
            return data;
        }

        public async Task<IEnumerable<Shelf>> GetByUserId(int userId)
        {
            var response = await GetClient().GetAsync($"Shelf/GetByUserId?userId={userId}");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<IEnumerable<Shelf>>() : null;
            return data;
        }

        public async Task<IEnumerable<ShelfListHome>> GetShelfListHomes(int userId)
        {
            var response = await GetClient().GetAsync($"Shelf/GetShelfListHomes?userId={userId}");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<IEnumerable<ShelfListHome>>() : null;
            return data;
        }

        public async Task<double> GetTotalByUserId(int userId)
        {
            var response = await GetClient().GetAsync($"Shelf/GetTotalByUserId?userId={userId}");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<double>() : 0;
            return data;
        }
        
        public async Task<double> GetTotalReadByUserId(int userId)
        {
            var response = await GetClient().GetAsync($"Shelf/GetTotalReadByUserId?userId={userId}");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<double>() : 0;
            return data;
        }

        public async Task<int> Update(Shelf shelf)
        {
            var response = await GetClient().PutAsJsonAsync($"Shelf/Update", shelf);
            var data = response.IsSuccessStatusCode ? 1 : 0;
            return data;
        }
    }
}
