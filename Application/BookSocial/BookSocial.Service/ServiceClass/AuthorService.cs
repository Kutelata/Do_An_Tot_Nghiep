﻿using BookSocial.EntityClass.Entity;
using BookSocial.Service.ServiceInterface;
using System.Net.Http.Json;

namespace BookSocial.Service.ServiceClass
{
    public class AuthorService : ConnectAPI, IAuthorService
    {
        public async Task<int> Create(Author author)
        {
            var response = await GetClient().PostAsJsonAsync($"Author/Create", author);
            var data = response.IsSuccessStatusCode ? 1 : 0;
            return data;
        }

        public async Task<int> Delete(int authorId)
        {
            var response = await GetClient().DeleteAsync($"Author/Delete?id={authorId}");
            var data = response.IsSuccessStatusCode ? 1 : 0;
            return data;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            var response = await GetClient().GetAsync($"Author/GetAll");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<IEnumerable<Author>>() : null;
            return data;
        }

        public async Task<Author> GetById(int authorId)
        {
            var response = await GetClient().GetAsync($"Author/GetById?id={authorId}");
            var data = response.IsSuccessStatusCode
                ? await response.Content.ReadFromJsonAsync<Author>() : null;
            return data;
        }

        public async Task<int> Update(Author author)
        {
            var response = await GetClient().PutAsJsonAsync($"Author/Update", author);
            var data = response.IsSuccessStatusCode ? 1 : 0;
            return data;
        }
    }
}
