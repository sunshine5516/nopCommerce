using System.Collections.Generic;
using Nop.Core;
using Nop.Core.Domain.Seo;

namespace Nop.Services.Seo
{
    /// <summary>
    /// �ṩ�й�URL��¼����Ϣ
    /// </summary>
    public partial interface  IUrlRecordService
    {
        /// <summary>
        /// ɾ��һ��URL��¼
        /// </summary>
        /// <param name="urlRecord">URL record</param>
        void DeleteUrlRecord(UrlRecord urlRecord);

        /// <summary>
        /// ɾ��URL��¼
        /// </summary>
        /// <param name="urlRecords">URL records</param>
        void DeleteUrlRecords(IList<UrlRecord> urlRecords);

        /// <summary>
        /// ��ȡURL��¼
        /// </summary>
        /// <param name="urlRecordId">URL recordId</param>
        /// <returns>URL record</returns>
        UrlRecord GetUrlRecordById(int urlRecordId);

        /// <summary>
        /// ��ȡURL��¼
        /// </summary>
        /// <param name="urlRecordIds">urlRecordIds</param>
        /// <returns>URL record</returns>
        IList<UrlRecord> GetUrlRecordsByIds(int [] urlRecordIds);

        /// <summary>
        /// ����һ��URL��¼
        /// </summary>
        /// <param name="urlRecord">URL record</param>
        void InsertUrlRecord(UrlRecord urlRecord);

        /// <summary>
        /// ����һ��URL��¼
        /// </summary>
        /// <param name="urlRecord">URL record</param>
        void UpdateUrlRecord(UrlRecord urlRecord);

        /// <summary>
        /// ����URL��¼
        /// </summary>
        /// <param name="slug">Slug</param>
        /// <returns>Found URL record</returns>
        UrlRecord GetBySlug(string slug);

        /// <summary>
        /// ����URL��¼������汾����
        /// �˷����Ĺ�����ʽ�롰GetBySlug��һ��������������
        /// ��ˣ��������ڿ���е������Ż�
        /// </summary>
        /// <param name="slug">Slug</param>
        /// <returns>Found URL record</returns>
        UrlRecordService.UrlRecordForCaching GetBySlugCached(string slug);

        /// <summary>
        /// ��ȡ����URL��¼
        /// </summary>
        /// <param name="slug">Slug</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>URL records</returns>
        IPagedList<UrlRecord> GetAllUrlRecords(string slug = "", int pageIndex = 0, int pageSize = int.MaxValue);

        /// <summary>
        /// Find slug
        /// </summary>
        /// <param name="entityId">Entity identifier</param>
        /// <param name="entityName">Entity name</param>
        /// <param name="languageId">Language identifier</param>
        /// <returns>Found slug</returns>
        string GetActiveSlug(int entityId, string entityName, int languageId);

        /// <summary>
        /// Save slug
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity</param>
        /// <param name="slug">Slug</param>
        /// <param name="languageId">Language ID</param>
        void SaveSlug<T>(T entity, string slug, int languageId) where T : BaseEntity, ISlugSupported;
    }
}