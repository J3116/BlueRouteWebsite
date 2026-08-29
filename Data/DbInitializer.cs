using BluelineWebsite.Models;

namespace BluelineWebsite.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Services.Any())
            {
                return; // DB has been seeded already
            }

            var services = new Service[]
            {
                new Service
                {
                    TitleEn = "Maritime Consultancy & Studies",
                    TitleAr = "الاستشارات والدراسات البحرية",
                    Slug = "maritime-consultancy-and-studies",
                    ShortDescriptionEn = "Technical and engineering studies, economic analysis, risk evaluation, and port terminal optimization.",
                    ShortDescriptionAr = "دراسات فنية وهندسية، دراسات جدوى واقتصادية، تحليل المخاطر، والدراسات البيئية والهيدرولوجية للموانئ.",
                    FullDescriptionEn = "Comprehensive maritime consultancy covering technical & engineering studies, economic & financial evaluations, risk analysis, environmental & hydrological studies, and port & marine terminal support.",
                    FullDescriptionAr = "تقديم دراسات فنية وهندسية واقتصادية متكاملة، تحليل المخاطر، دراسات البينة والبيئية والهيدرولوجية، ودعم الموانئ والمحطات البحرية بمعايير عالمية.",
                    IconCssClass = "fa-ship",
                    IsFeatured = true,
                    IsActive = true
                },
                new Service
                {
                    TitleEn = "Strategic Consultancy & Development",
                    TitleAr = "الاستشارات الاستراتيجية والتطوير",
                    Slug = "strategic-consultancy-and-development",
                    ShortDescriptionEn = "Strategic planning, policy development, business restructuring, and sustainability support.",
                    ShortDescriptionAr = "التخطيط الاستراتيجي، تطوير السياسات والإجراءات، إعادة هيكلة العمليات البحرية، وتطوير معايير الجودة.",
                    FullDescriptionEn = "Expert strategic planning, policy & procedure development, business restructuring, quality management systems, and long-term sustainability support for maritime organizations.",
                    FullDescriptionAr = "التخطيط الاستراتيجي المتقدم، تطوير السياسات والإجراءات التنظيمية، إعادة هيكلة العمليات البحرية، تطوير معايير الجودة، ودعم الاستدامة لقطاع النقل البحري.",
                    IconCssClass = "fa-chart-line",
                    IsFeatured = true,
                    IsActive = true
                },
                new Service
                {
                    TitleEn = "Maritime Security Assessments",
                    TitleAr = "التقييمات الأمنية والبحرية",
                    Slug = "maritime-security-assessments",
                    ShortDescriptionEn = "Port and ship security assessments under ISPS Code, risk evaluations, and compliance audits.",
                    ShortDescriptionAr = "تقييم أمن والسلامة (ISPS Code)، تقييم المخاطر وتعديل الأمن، وتقييم الامتثال الفني والاستشاري.",
                    FullDescriptionEn = "Professional port and ship security assessments under the ISPS Code, vulnerability analysis, risk evaluation, compliance assessments, and detailed technical advisory reports.",
                    FullDescriptionAr = "إجراء تقييم أمن السفن والموانئ تحت مدونة (ISPS Code)، تقييم المخاطر وتحليل الثغرات الأمنية، تقييم الامتثال الفني، وتقديم التقارير الاستشارية المتخصصة.",
                    IconCssClass = "fa-shield-alt",
                    IsFeatured = true,
                    IsActive = true
                },
                new Service
                {
                    TitleEn = "Training & Capacity Building",
                    TitleAr = "التعليم والدعم الفني",
                    Slug = "training-and-capacity-building",
                    ShortDescriptionEn = "Specialized training programs in maritime safety, security, risk management, and organizational capacity.",
                    ShortDescriptionAr = "برامج تدريب متخصصة في السلامة والأمن البحري، إدارة المخاطر والامتثال، وبناء القدرات المؤسسية.",
                    FullDescriptionEn = "Specialized training programs focused on maritime safety and security, risk management and compliance, and comprehensive capacity building for maritime organizations and crews.",
                    FullDescriptionAr = "برامج تدريبية متخصصة في السلامة والأمن البحري، إدارة المخاطر والامتثال للقوانين الدولية، وبناء قدرات المؤسسات والكوادر البشرية العاملة في القطاع.",
                    IconCssClass = "fa-graduation-cap",
                    IsFeatured = true,
                    IsActive = true
                },
                new Service
                {
                    TitleEn = "Supervision & Technical Support",
                    TitleAr = "الإشراف والدعم الفني",
                    Slug = "supervision-and-technical-support",
                    ShortDescriptionEn = "Supervision of maritime projects, review of designs, technical assessments, and operational planning.",
                    ShortDescriptionAr = "الإشراف على المشاريع البحرية، مراجعة التصاميم والمخططات، والدراسات الفنية التشغيلية.",
                    FullDescriptionEn = "End-to-end supervision of maritime projects, architectural and structural design reviews, rigorous technical assessments & studies, and operational planning support.",
                    FullDescriptionAr = "الإشراف الميداني والهندسي على المشاريع البحرية، مراجعة التصاميم والمخططات الهندسية، إعداد الدراسات والتقييمات الفنية، وتقديم خطط الدعم التشغيلي.",
                    IconCssClass = "fa-tools",
                    IsFeatured = true,
                    IsActive = true
                }
            };

            context.Services.AddRange(services);
            context.SaveChanges();
        }
    }
}