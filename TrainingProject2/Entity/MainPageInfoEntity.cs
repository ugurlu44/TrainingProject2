using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingProject2.Common;

namespace TrainingProject2.Entity
{
    public class MainPageInfoEntity
    {
        public string Comment { get; set; }

        public MainPageEditableEnum CommentType { get; set; }

        public bool IsActive { get; set; }

        public DateTime AddedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string Explanation { get; set; }

        public string Info { get; set; }
    }
}