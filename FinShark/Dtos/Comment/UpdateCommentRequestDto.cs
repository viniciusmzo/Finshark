﻿namespace FinShark.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
