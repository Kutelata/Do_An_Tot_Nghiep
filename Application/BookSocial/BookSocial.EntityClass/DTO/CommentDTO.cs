﻿namespace BookSocial.EntityClass.DTO
{
    public class CommentStatistic
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ParentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int NumberCommentReplies { get; set; }
    }

    public class RecentActivityComment
    {
        public int UserCommentId { get; set; }
        public int UserName { get; set; }
        public int UserReviewId { get; set; }
        public string UserReviewName { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime CommentCreatedAt { get; set; }
    }
}
