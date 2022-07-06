using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson23.Contracts;
using Lesson23.DataAccess;

namespace Lesson23.Domain
{

	public class RoomService
	{
		private IDataAccess _dataAccess;
		public RoomService(IDataAccess dataAccess)
		{
			this._dataAccess = dataAccess;
		}

		public List<Room> GetAll()
		{
			return this._dataAccess.GetAll();
		}
		public void WriteAll(List<Room> rooms)
		{
			this._dataAccess.WriteAll(rooms);
		}

		public bool IsBooked(Room room, DateTime time)
		{
			return room.Meetings.Select(x => x.Date).Any(x => x == time);
		}
	}
}
