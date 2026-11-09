# 🚀 ASP.NET Core 6.0 MVC Dynamic Portfolio & Admin Dashboard

Bu proje; kişisel portfolyo verilerinin, projelerin, yeteneklerin, eğitimlerin ve gelen mesajların dinamik olarak yönetilebildiği modern bir **Kişisel Portfolyo ve Yönetim Paneli (Admin Dashboard)** web uygulamasıdır.

Proje, katmanlı mimari prensiplerine uygun olarak **ASP.NET Core 6.0 MVC** ve **Entity Framework Core** ile geliştirilmiştir.

---

## 📸 Proje Ekran Görüntüleri

### 🖥️ Kullanıcı Arayüzü (Ön Yüz / Visitor View)

| Ana Sayfa | Hakkımda |
| :---: | :---: |
| ![Ana Sayfa](wwwroot/images/UıHomePage.png) | ![Hakkımda](wwwroot/images/uiAbout.png) |

| Projeler | Yetenekler |
| :---: | :---: |
| ![Projeler](wwwroot/images/uiProject.png) | ![Yetenekler](wwwroot/images/uiSkill.png) |

| Eğitim | Deneyim |
| :---: | :---: |
| ![Eğitim](wwwroot/images/uiEducation.png) | ![Deneyim](wwwroot/images/uiExperience.png) |

| Sertifikalar | İletişim |
| :---: | :---: |
| ![Sertifikalar](wwwroot/images/uiCertifica.png) | ![İletişim](wwwroot/images/uiContact.png) |

---

### ⚙️ Yönetim Paneli (Admin Dashboard & Management)

| Admin Dashboard | Proje Yönetimi |
| :---: | :---: |
| ![Dashboard](wwwroot/images/Homepage.png) | ![Projeler](wwwroot/images/Project.png) |

| Hakkımda Yönetimi | Yetenek Yönetimi |
| :---: | :---: |
| ![Hakkımda](wwwroot/images/About.png) | ![Yetenekler](wwwroot/images/Skill.png) |

| Eğitim Yönetimi | Deneyim Yönetimi |
| :---: | :---: |
| ![Eğitim](wwwroot/images/Education.png) | ![Deneyim](wwwroot/images/Experience.png) |

| Mesajlar | Profil |
| :---: | :---: |
| ![Mesajlar](wwwroot/images/Message.png) | ![Profil](wwwroot/images/Profile.png) |

| Ayarlar |
| :---: |
| ![Ayarlar](wwwroot/images/setting.png) |

---

## 🛠️ Öne Çıkan Özellikler ve Arayüz Bileşenleri

- **Dinamik İstatistik Kartları:** Toplam proje, toplam mesaj, okunmuş/okunmamış mesaj ve aktif yetenek sayıları veritabanından anlık çekilir ve tıklanabilir yönlendirme kartları şeklinde sunulur.
- **Son Eklenen Projeler Tablosu:** Dashboard üzerinde en son eklenen 5 proje LINQ sorgusuyla (`OrderByDescending` & `Take(5)`) kategorileriyle birlikte dinamik olarak listelenir.
- **Yetenek & Teknoloji Seviyeleri:** Sağ panelde yetenek yetkinlik oranları Bootstrap `progress-bar` bileşenleri ile görselleştirilmiştir.
- **Modüler Yapı (ViewComponent):** Dashboard üzerindeki bileşenler, istatistik alanları ve dinamik bölümler `ViewComponent` mimarisiyle modüler ve tekrar kullanılabilir şekilde tasarlanmıştır.
- **Kapsamlı Yönetim Modülleri:** Hakkımda, Eğitimler, Deneyimler, Yetenekler, Projeler, Mesajlar ve Profil ayarları Admin paneli üzerinden kolayca güncellenebilir.

---

## 💻 Kullanılan Teknolojiler

* **Backend:** ASP.NET Core 6.0 MVC
* **ORM & Database:** Entity Framework Core (Code-First / DB-First), Microsoft SQL Server (MSSQL)
* **Güvenlik & Yetkilendirme:** ASP.NET Core Authentication & Cookie tabanlı Authorize yetkilendirmesi (`[Authorize]`, `[Area("Admin")]`)
* **Frontend:** Bootstrap 5, HTML5, CSS3, JavaScript, Bootstrap Icons
* **Mimari Yapılar:** Area Mimarisi, LINQ Sorguları, ViewComponent, DTO & Model Yönetimi, ViewBag Veri Taşıma

---

## 📂 Proje Klasör Yapısı

```text
MyPortfolioProject/
│
├── Areas/
│   └── Admin/                 # Admin Yönetim Paneli (Dashboard, Project, Skill, Message vb.)
│       ├── Controllers/
│       └── Views/
│
├── Controllers/               # Ön Yüz (Portfolio) Controller'ları
├── Entities / Models/         # Entity Sınıfları ve ViewModel Yapıları
├── Context/                   # PortfolioContext (EF Core DbContext)
├── ViewComponents/            # Modüler İstatistik ve İlerleme Bileşenleri
├── wwwroot/
│   └── images/                # Ekran Görüntüleri ve Görsel Varlıklar
└── Program.cs                 # Dependency Injection ve Pipeline Yapılandırması
