using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using BaseOfTalents.Models;
using BaseOfTalents.DAL.Mappings;

namespace BaseOfTalents.DAL
{
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    var config = GetConfiguration();

                    config.AddDeserializedMapping(GetMappings(), "BaseOfTalents");
                    SchemaMetadataUpdater.QuoteTableAndColumns(config);

                    sessionFactory = config.BuildSessionFactory();
                    new SchemaExport(config).Create(true, true);
                }

                return sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        private static Configuration GetConfiguration()
        {
            var config = new Configuration();

            config.DataBaseIntegration(db =>
            {
                db.Dialect<MsSql2008Dialect>();
                db.Driver<SqlClientDriver>();
                db.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                db.IsolationLevel = IsolationLevel.ReadCommitted;
                db.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\App_Data\\HRDatabase.mdf;Integrated Security=True";

                db.LogFormattedSql = true;
                db.LogSqlInConsole = true;
                db.AutoCommentSql = true;
            });

            return config;
        }

        private static HbmMapping GetMappings()
        {
            ModelMapper mapper = new ModelMapper();
            mapper.AddMapping<CandidateMap>();
            mapper.AddMapping<VacancyMap>();

            HbmMapping mapping = mapper.CompileMappingFor(new[] { typeof(Candidate), typeof(Vacancy) });

            return mapping;
        }
    }
}