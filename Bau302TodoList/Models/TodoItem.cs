using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bau302TodoList.Models
{
    public class TodoItem:BaseEntity
    {
        [StringLength(200), Required(ErrorMessage = "Bu alan doldurulmalıdır!"), DisplayName("Başlık")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Durum")]
        public Status Status { get; set; }
        [DisplayName("Kategori")]
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [DisplayName("Dosya Eki")]
        public string Attachment { get; set; }
        [DisplayName("Departman")]
        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        [DisplayName("Taraf")]
        public int? SideId { get; set; }
        [ForeignKey("SideId")]
        public virtual Side Side { get; set; }
        [DisplayName("Müşteri")]
        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [DisplayName("Yönetici")]
        public int? ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual Contact Manager { get; set; }
        [DisplayName("Organizatör")]
        public int? OrganizatorId { get; set; }
        [ForeignKey("OrganizatorId")]
        public virtual Contact Organizator { get; set; }
        [DisplayName("Toplantı Tarihi")]
        [DataType("datetime-local")]
        [Required(ErrorMessage = "Tarih girilmelidir!")]
        public DateTime MeetingDate { get; set; }
        [DisplayName("Planlama Tarihi")]
        [DataType("datetime-local")]
        [Required(ErrorMessage = "Tarih girilmelidir!")]
        public DateTime PlannedDate { get; set; }
        [DisplayName("Bitirme Tarihi")]
        [DataType("datetime-local")]
        [Required(ErrorMessage = "Tarih girilmelidir!")]
        public DateTime FinishDate { get; set; }
        [DisplayName("Revize Tarihi")]
        [DataType("datetime-local")]
        [Required(ErrorMessage = "Tarih girilmelidir!")]
        public DateTime ReviseDate { get; set; }
        [DisplayName("Görüşme Konusu")]
        public string ConversationSubject { get; set; }
        [DisplayName("Destekleyen Firma")]
        public string SupporterCompany { get; set; }
        [DisplayName("Destekleyen Doktor ")]
        public string SupporterDoctor { get; set; }
        [DisplayName("Görüşme Katılımcı Sayısı")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public int ConversationAttendeeCount { get; set; }
        [DisplayName("Planlanan Organizasyon Tarihi")]
        [DataType("datetime-local")]
        [Required(ErrorMessage = "Tarih girilmelidir!")]
        public DateTime ScheduledOrganizationDate { get; set; }
        [DisplayName("Mailleşme Konusu")]
        public string MaillingSubject { get; set; }
        [DisplayName("Afiş Konusu")]
        public string PosterSubject { get; set; }
        [DisplayName("Afiş Sayısı")]
        public int PosterCount { get; set; }
        [DisplayName("Uzaktan Öğrenme")]
        public string Elearning { get; set; }
        [DisplayName("Tarama Türleri")]
        public string TypesOfScans { get; set; }
        [DisplayName("Taramalardaki Aso Sayısı")]
        public string AsoCountInScans { get; set; }
        [DisplayName("Organizasyon Türleri")]
        public string TypesOfOrganization { get; set; }
        [DisplayName("Organizasyondaki Aso Sayısı")]
        public string AsoCountInOrganization { get; set; }
        [DisplayName("Aşı Ogranizayonu Türleri")]
        public string TypesOfVaccinationOrganization { get; set; }
        [DisplayName("Aşı Ogranizayonundaki Aso Sayısı")]
        public string AsoCountInVaccinationOrganization { get; set; }
        [DisplayName("Afiş İçin Tazminat Miktarı")]
        public string AmountOfCompensationForPoster { get; set; }
        [DisplayName("Kurumsal Verimlilik Raporu")]
        public string CorporateProductivityReport { get; set; }




        
    }
}