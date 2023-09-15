﻿using System;
using System.Collections.Generic;
using ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL;
using ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.USER_MODEL;

namespace ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.QC_CHECKLIST
{
    public class ChecklistQuestions : BaseEntity
    {
        public string ChecklistQuestion { get; set; }
        public int ProductTypeId { get; set; }
        public bool IsActive { get; set; } = true;
        public int AddedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public bool IsOpenField { get; set; }

        public virtual User AddedByUser { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}