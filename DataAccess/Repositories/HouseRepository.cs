using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class HouseRepository : Repository<House>,IHouseRepository
    {
        public HouseRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task DeleteByRequestAsync(Request request)
        {
            List<House> houses =await _appDbContext.Houses.Where(
                    h =>
                        (
                            h.Address.CityName == request.CityName ||
                            request.CityName == null
                        ) &&
                        (
                            h.Address.DistrictName == request.DistrictName ||
                            request.DistrictName == null
                        ) &&
                        (
                            h.Address.NeighborhoodName == request.NeighborhoodName ||
                            request.NeighborhoodName == null
                        ) &&
                        (
                            h.Status == request.Status ||
                            request.Status == null
                        ) &&
                        (
                            h.Type == request.Type ||
                            request.Type == null
                        ) &&
                        (
                            request.MinCountOfRooms <= h.CountOfRooms ||
                            request.MinCountOfRooms == null
                        ) &&
                        (
                            h.CountOfRooms <= request.MaxCountOfRooms ||
                            request.MaxCountOfRooms == null
                        ) &&
                        (
                            request.MinPrice <= h.Price ||
                            request.MinPrice == null
                        ) &&
                        (
                            h.Price <= request.MaxPrice ||
                            request.MaxPrice == null
                        ) &&
                        (
                            request.MinSquareMeter <= h.SquareMeter ||
                            request.MinSquareMeter == null
                        ) &&
                        (
                            h.SquareMeter <= request.MaxSquareMeter ||
                            request.MaxSquareMeter == null
                        )
                ).ToListAsync();
            if (houses != null)
                _appDbContext.Houses.RemoveRange(houses);
        }

        public async Task DeleteByUserIdAsync(int userId)
        {
            List<House> houses = await _appDbContext.Houses
                    .Where(h => h.UserId == userId)
                    .ToListAsync();
            if (houses != null)
                _appDbContext.Houses.RemoveRange(houses);
        }

        public async Task DeleteByUserNameAsync(string userName)
        {

            List<House> houses =await _appDbContext.Houses
                    .Where(h => h.User.UserName == userName)
                    .ToListAsync();
            if (houses != null)
                _appDbContext.Houses.RemoveRange(houses);
        }


        public async Task<List<House>> GetByRequestAsync(Request request)
        {
            return await _appDbContext.Houses.Where(
                    h =>
                        (
                            h.Address.CityName == request.CityName ||
                            h.Address.CityName == null
                        ) &&
                        (
                            h.Address.DistrictName == request.DistrictName ||
                            h.Address.DistrictName == null
                        ) &&
                        (
                            h.Address.NeighborhoodName == request.NeighborhoodName ||
                            h.Address.NeighborhoodName == null
                        ) &&
                        (
                            h.Status == request.Status ||
                            request.Status == null
                        ) &&
                        (
                            h.Type == request.Type ||
                            request.Type == null
                        ) &&
                        (
                            request.MinCountOfRooms <= h.CountOfRooms ||
                            request.MinCountOfRooms == null
                        ) &&
                        (
                            h.CountOfRooms <= request.MaxCountOfRooms ||
                            request.MaxCountOfRooms == null
                        ) &&
                        (
                            request.MinPrice <= h.Price ||
                            request.MinPrice == null
                        ) &&
                        (
                            h.Price <= request.MaxPrice ||
                            request.MaxPrice == null
                        ) &&
                        (
                            request.MinSquareMeter <= h.SquareMeter ||
                            request.MinSquareMeter == null
                        ) &&
                        (
                            h.SquareMeter <= request.MaxSquareMeter ||
                            request.MaxSquareMeter == null
                        )
                ).ToListAsync();
        }

        

        
        public async Task<List<House>> GetByUserIdAsync(int userId)
        {
            return await _appDbContext.Houses.Where(h => h.UserId == userId).ToListAsync();
        }
    

        public async Task<List<House>> GetByUserNameAsync(string userName)
        {
            return await _appDbContext.Houses
                    .Where(h => h.User.UserName == userName)
                    .ToListAsync();
        }

        public async Task<House> GetWithAddressAndImagesByIdAsync(int id)
        {
            return await _appDbContext.Houses.Include(h => h.Address).Include(h => h.Images).SingleOrDefaultAsync(h => h.Id == id);
        }

    }
}
