using Autofac;
using CryptoWatcherLib.DataAccess.Api;
using CryptoWatcherLib.DataAccess.AppConfig;
using CryptoWatcherLib.DataAccess.Db;
using CryptoWatcherLib.DataAccess.Graph;
using CryptoWatcherLib.DataManagers.CurrencyPrice;
using CryptoWatcherLib.DataManagers.Purchases;
using CryptoWatcherLib.DataManagers.User;
using CryptoWatcherLib.Models;

namespace CryptoWatcherLib
{
    /// <summary>
    /// This singleton & factory class is providing a container, which allows other classes to resolve objects with.
    /// Because the class is a singleton, there is only one instance while running.
    /// </summary>
    public class ServiceFactory
    {
        private IUser _user;

        private static ServiceFactory _instance;

        private IContainer _container;
        private ContainerBuilder _builder;

        /// <summary>
        /// The contructor is private, because there is only one way to get a instance of this class
        /// </summary>
        private ServiceFactory()
        {

        }

        /// <summary>
        /// This field stores an instance of the TimeMgmtFactory class.
        /// </summary>
        public static ServiceFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ServiceFactory();
                    _instance.Initialize();
                }
                return _instance;
            }
        }

        /// <summary>
        /// This field stores an instance of the user that is logged in.
        /// Through out the whole application it is possible to access the user.
        /// </summary>
        public IUser UserInstance
        {
            get
            {
                if (_user != null)
                {
                    return _user;
                }

                throw new Exception("user is not set amk");
            }
            set => _user = value;
        }

        /// <summary>
        /// This method initialises the container.
        /// Every implementation of an interface can be registered in this method.
        /// </summary>
        public void Initialize()
        {
            _builder = new ContainerBuilder();

            InitializeDataAccess();
            InitializeDataManagers();
            
            _container = _builder.Build();
        }

        private void InitializeDataAccess()
        {
            _builder.RegisterType<ApiDataAccess>().As<IApiDataAccess>().SingleInstance();
            _builder.RegisterType<AppConfigAccess>().As<IAppConfigAccess>().SingleInstance();
            _builder.RegisterType<AdoDataAccess>().As<IDbDataAccess>().SingleInstance();
            _builder.RegisterType<GraphData>().As<IGraphData>().SingleInstance();
        }
        private void InitializeDataManagers()
        {
            _builder.RegisterType<CurrencyPriceDataReceiver>().As<ICurrencyPriceDataReceiver>().SingleInstance();
            _builder.RegisterType<PurchasesDbDataManager>().As<IPurchasesDbDataManager>().SingleInstance();
            _builder.RegisterType<UsersDbDataManager>().As<IUsersDbDataManager>().SingleInstance();
        }

        /// <summary>
        /// This method returns the class that implements an interface that is initialised
        /// </summary>
        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
