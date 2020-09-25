using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{
    public interface INoticeBoardRepository
    {
        Task<List<NoticeBoard>> GetAllNoticeBoards();

        Task<NoticeBoard> GetNoticeBoard(int id);

        Task<int> AddNoticeBoard(NoticeBoard noticeBoard);

        Task UpdateNoticeBoard(NoticeBoard noticeBoard);
        Task<int> DeleteNoticeBoard(int? id);
        IEnumerable<NoticeBoard> GetAllNoticeByEarlierDateTime();
        public IEnumerable<NoticeBoard> GetAllBranchWiseNotice(int BranchId, int year);
    }

}
