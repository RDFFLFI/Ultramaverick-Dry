﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ELIXIR.DATA.DATA_ACCESS_LAYER.HELPERS;
using ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL;
using ELIXIR.DATA.DTOs.SETUP_DTOs;

namespace ELIXIR.DATA.CORE.INTERFACES.SETUP_INTERFACE
{
    public interface ILabtestMasterlist
    {
        #region Sample Types
        Task<bool> AddNewSampleType(SampleType sampleType);
        Task<bool> UpdateSampleType(SampleType sampleTypes);
        Task<IReadOnlyList<SampleType>> GetAllSampleType();
        Task<SampleType> GetSampleTypeById(int id);
        Task<IEnumerable<SampleType>> GetAllSampleTypeByStatus(bool status);
        Task<SampleType> GetSampleTypeByName(string sampleTypeName);
        Task<PagedList<SampleTypeDto>> GetAllSampleTypePagination(bool status, UserParams userParams);
        Task<PagedList<SampleTypeDto>> GetAllSampleTypePaginationOrig(string search, bool status, UserParams userParams);
        Task<PagedList<SampleTypeDto>> GetAllSampleTypeByStatusPagination(bool status, UserParams userParams);
        Task<PagedList<SampleTypeDto>> GetAllSampleTypeByStatusPaginationOrig(string search, bool status, UserParams userParams);
        Task<bool> UpdateSampleTypeStatus(SampleType sampleTypes);

        #endregion

        #region Type Of Swabs

        Task<bool> AddNewTypeOfSwab(TypeOfSwab typeOfSwab);
        Task<bool> UpdateTypeOfSwab(TypeOfSwab typeOfSwab);
        Task<IReadOnlyList<TypeOfSwab>> GetAllTypeOfSwab();
        Task<TypeOfSwab> GetTypeOfSwabById(int id);
        Task<TypeOfSwab> GetTypeofSwabByName(string typeOfSwabNAme);
        Task<IEnumerable<TypeOfSwab>> GetAllTypeOfSwabByStatus(bool status);
        Task<PagedList<TypeOfSwabDto>> GetAllTypeOfSwabPagination(bool status, UserParams userParams);
        Task<PagedList<TypeOfSwabDto>> GetAllTypeOfSwabPaginationOrig(string search, bool status, UserParams userParams);
        Task<PagedList<TypeOfSwabDto>> GetTypeOfSwabByStatusPaginationOrig(string search, bool status, UserParams userParams);
        Task<bool> UpdateTypeOfSwabStatus(TypeOfSwab typeOfSwab);

        #endregion

        #region Analysis

        Task<bool> AddNewAnalysis(Analysis analysis);
        Task<bool> UpdateAnalysis(Analysis analysis);
        Task<IReadOnlyList<Analysis>> GetAllAnalysis();
        Task<IEnumerable<Analysis>> GetAllAnalysisByStatus(bool status);
        Task<Analysis> GetAnalaysisByName(string analysisName);
        Task<PagedList<AnalysesDto>> GetAllAnalysesPagination(bool status, UserParams userParams);
        Task<PagedList<AnalysesDto>> GetAllAnalysesPaginationOrig(string search, bool status, UserParams userParams);
        Task<PagedList<AnalysesDto>> GetAnalysisByStatusPaginationOrig(string search, bool status, UserParams userParams);
        Task<bool> UpdateAnalysisStatus(Analysis analysis);
        Task<Analysis> GetAnalysisById(int id);

        #endregion

        #region Parameteres

        Task<bool> AddNewParameter(Parameters parameters);
        Task<bool> UpdateParameters(Parameters parameters);
        Task<Parameters> GetParametersById(int id);
        Task<IEnumerable<Parameters>> GetAllParametersByStatus(bool status);
        Task<IReadOnlyList<Parameters>> GetAllParameters();
        Task<Parameters> GetParametersByName(string name);
        Task<PagedList<ParametersDto>> GetAllParametersPagination(bool status, UserParams userParams);
        Task<PagedList<ParametersDto>> GetAllParametersPaginationOrig(string search, bool status, UserParams userParams);
        Task<bool> UpdateParameterStatus(Parameters parameters);

        #endregion

        #region Product Condition

        Task<bool> AddNewProductCondition(ProductCondition productCondition);
        Task<bool> UpdateProductCondition(ProductCondition productCondition);
        Task<IReadOnlyList<ProductCondition>> GetAllProductCondition();
        Task<ProductCondition> GetProductConditionById(int id);
        Task<IEnumerable<ProductCondition>> GetAllProductConditionByStatus(bool status);
        Task<PagedList<ProductConditionDto>> GetAllProductConditionPagination(bool status, UserParams userParams);
        Task<PagedList<ProductConditionDto>> GetAllProductConditionPaginationOrig(string search, bool status, UserParams userParams);
        Task<bool> UpdateProductConditionStatus(ProductCondition productCondition);
        Task<ProductCondition> GetProductConditionByName(string productConditionName);

        #endregion

        #region Disposition
        Task<bool> AddNewDisposition(Disposition disposition);
        Task<bool> UpdateDisposition(Disposition disposition);
        Task<IReadOnlyList<Disposition>> GetAllDisposition();
        Task<Disposition> GetDispositionById(int id);
        Task<Disposition> GetDispositonByName(string dispositionName);
        Task<IEnumerable<Disposition>> GetAllDispositionByStatus(bool status);
        Task<PagedList<DispositionDto>> GetAllDispositionPagination(bool status, UserParams userParams);
        Task<PagedList<DispositionDto>> GetAllDispositionPaginationOrig(string search, bool status, UserParams userParams);
        Task<bool> UpdateDispositionStatus(Disposition disposition);
        #endregion
    }
}