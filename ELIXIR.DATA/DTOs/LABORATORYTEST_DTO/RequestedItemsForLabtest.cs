﻿namespace ELIXIR.DATA.DTOs.LABORATORYTEST_DTO
{
    public class RequestedItemsForLabtest
    {
        public int Id
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

        public string ExpirationDate
        {
            get;
            set;
        }

        public int WarehouseId
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }
    }
}