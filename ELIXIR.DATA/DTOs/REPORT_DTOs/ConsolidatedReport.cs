﻿using System;

namespace ELIXIR.DATA.DTOs.REPORT_DTOs
{
    public class ConsolidatedReport
    {
        public int Id
        {
            get;
            set;
        }

        public DateTime? TransactionDate
        {
            get;
            set;
        }

        public string ItemCode
        {
            get;
            set;
        }

        public string ItemDescription
        {
            get;
            set;
        }

        public decimal Quantity
        {
            get;
            set;
        }

        public int WarehouseId
        {
            get;
            set;
        }

        public string TransactionType
        {
            get;
            set;
        }

        public string CompanyCode
        {
            get;
            set;
        }

        public string CompanyName
        {
            get;
            set;
        }

        public string DepartmentName
        {
            get;
            set;
        }

        public string LocationName
        {
            get;
            set;
        }

        public string AccountTitle
        {
            get;
            set;
        }
    }
}