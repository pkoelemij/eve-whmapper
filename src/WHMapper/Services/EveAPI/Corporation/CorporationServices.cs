﻿namespace WHMapper.Services.EveAPI.Corporation
{
    public class CorporationServices : EveApiServiceBase, ICorporationServices

    {
        public CorporationServices(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<Models.DTO.EveAPI.Corporation.Corporation?> GetCorporation(int corporation_id)
        {
            return await base.Execute<Models.DTO.EveAPI.Corporation.Corporation>(RequestSecurity.Public, RequestMethod.Get, string.Format("/v5/corporations/{0}/?datasource=tranquility", corporation_id));
        }
    }
}