﻿using BookSocial.EntityClass.DTO;
using BookSocial.EntityClass.Entity;

namespace BookSocial.Service.ServiceInterface
{
    public interface IShelfService
    {
        Task<IEnumerable<Shelf>> GetByBookId(int bookId);
        Task<IEnumerable<Shelf>> GetByUserId(int userId);
        Task<Shelf> GetByBookAndUserId(int bookId, int userId);
        Task<double> GetTotalByUserId(int userId);
        Task<double> GetTotalReadByUserId(int userId);
        Task<IEnumerable<ShelfDetail>> GetByShelfDetail(int userId);
        Task<IEnumerable<ShelfListHome>> GetShelfListHomes(int userId);
        Task<int> Create(Shelf shelf);
        Task<int> Update(Shelf shelf);
        Task<int> DeleteByBookAndUserId(int bookId, int userId);
    }
}
