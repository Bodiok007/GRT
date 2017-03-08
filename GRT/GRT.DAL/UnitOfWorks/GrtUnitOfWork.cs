using GRT.DAL.Models.Languages;
using GRT.DAL.Models.Levels;
using GRT.DAL.Models.Levels.Dialogs;
using GRT.DAL.Models.Menus;
using GRT.DAL.Models.Tokens;
using GRT.DAL.Models.UserProject;
using GRT.DAL.Repositories.Base;
using GRT.DAL.Repositories.EF.Languages;
using GRT.DAL.Repositories.EF.Levels;
using GRT.DAL.Repositories.EF.Levels.Dialogs;
using GRT.DAL.Repositories.EF.Menus;
using GRT.DAL.Repositories.EF.Tokens;
using GRT.DAL.Repositories.EF.UserProject;
using GRT.DAL.Repositories.Interfaces.Languages;
using GRT.DAL.Repositories.Interfaces.Levels;
using GRT.DAL.Repositories.Interfaces.Menus;
using GRT.DAL.Repositories.Interfaces.UserProject;
using Microsoft.EntityFrameworkCore;
using System;

namespace GRT.DAL.UnitOfWorks
{
    public class GrtUnitOfWork : IDisposable
    {
        public GrtUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async void SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #region Properties

        #region UserProject

        public IProjectRepository<ProjectDal, Int32> ProjectRepository
        {
            get
            {
                if (_projectRepository == null)
                {
                    _projectRepository = new ProjectRepository(_context);
                }

                return _projectRepository;
            }
        }

        public BaseCRURepository<UserDal, Int32> UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }

                return _userRepository;
            }
        }

        public IPermissionRepository<PermissionDal, Int32> PermissionRepository
        {
            get
            {
                if (_permssionRepository == null)
                {
                    _permssionRepository = new PermissionRepository(_context);
                }

                return _permssionRepository;
            }
        }

        public IUserProjectPermissionRepository<UserProjectPermissionDal> UserProjectPermissionRepository
        {
            get
            {
                if (_userProjectPermissionRepository == null)
                {
                    _userProjectPermissionRepository = new UserProjectPermissionRepository(_context);
                }

                return _userProjectPermissionRepository;
            }
        }

        #endregion UserProject

        #region Menus

        public IMenuRepository<MenuDal, Int32> MenuRepository
        {
            get
            {
                if (_menuRepository == null)
                {
                    _menuRepository = new MenuRepository(_context);
                }

                return _menuRepository;
            }
        }

        public IMenuTranslateRepository<MenuTranslateDal> MenuTranslateRepository
        {
            get
            {
                if (_menuTranslateRepository == null)
                {
                    _menuTranslateRepository = new MenuTranslateRepository(_context);
                }

                return _menuTranslateRepository;
            }
        }

        public IMenuAttributeRepository<MenuAttributeDal, Int32> MenuAttributeRepository
        {
            get
            {
                if (_menuAttributeRepository == null)
                {
                    _menuAttributeRepository = new MenuAttributeRepository(_context);
                }

                return _menuAttributeRepository;
            }
        }

        public IMenuAttributeTranslateRepository<MenuAttributeTranslateDal> MenuAttributeTranslateRepository
        {
            get
            {
                if (_menuAttributeTranslateRepository == null)
                {
                    _menuAttributeTranslateRepository = new MenuAttributeTranslateRepository(_context);
                }

                return _menuAttributeTranslateRepository;
            }
        }

        public IMenuAttributeValueRepository<MenuAttributeValueDal, Int32> MenuAttributeValueRepository
        {
            get
            {
                if (_menuAttributeValueRepository == null)
                {
                    _menuAttributeValueRepository = new MenuAttributeValueRepository(_context);
                }

                return _menuAttributeValueRepository;
            }
        }

        public IMenuAttributeValueTranslateRepository<MenuAttributeValueTranslateDal> MenuAttributeValueTranslateRepository
        {
            get
            {
                if (_menuAttributeValueTranslateRepository == null)
                {
                    _menuAttributeValueTranslateRepository = new MenuAttributeValueTranslateRepository(_context);
                }

                return _menuAttributeValueTranslateRepository;
            }
        }

        #endregion Menus

        #region Levels

        public ILevelRepository<LevelDal, Int32> LevelRepository
        {
            get
            {
                if (_levelRepository == null)
                {
                    _levelRepository = new LevelRepository(_context);
                }

                return _levelRepository;
            }
        }

        public ILevelDialogRepository<LevelDialogDal> LevelDialogRepository
        {
            get
            {
                if (_levelDialogRepository == null)
                {
                    _levelDialogRepository = new LevelDialogRepository(_context);
                }

                return _levelDialogRepository;
            }
        }

        public BaseCRUDComplexKeyRepository<LevelTranslateDal> LevelTranslateRepository
        {
            get
            {
                if (_levelTranslateRepository == null)
                {
                    _levelTranslateRepository = new LevelTranslateRepository(_context);
                }

                return _levelTranslateRepository;
            }
        }

        #region Dialogs

        public BaseCRUDRepository<DialogDal, Int32> DialogRepository
        {
            get
            {
                if (_dialogRepository == null)
                {
                    _dialogRepository = new DialogRepository(_context);
                }

                return _dialogRepository;
            }
        }

        public BaseCRUDRepository<DialogRecordDal, Int32> DialogRecordRepository
        {
            get
            {
                if (_dialogRecordRepository == null)
                {
                    _dialogRecordRepository = new DialogRecordRepository(_context);
                }

                return _dialogRecordRepository;
            }
        }

        public BaseCRUDComplexKeyRepository<DialogRecordTranslateDal> DialogRecordTranslateRepository
        {
            get
            {
                if (_dialogRecordTranslateRepository == null)
                {
                    _dialogRecordTranslateRepository = new DialogRecordTranslateRepository(_context);
                }

                return _dialogRecordTranslateRepository;
            }
        }

        public BaseCRUDRepository<DialogTextDal, Int32> DialogTextRepository
        {
            get
            {
                if (_dialogTextRepository == null)
                {
                    _dialogTextRepository = new DialogTextRepository(_context);
                }

                return _dialogTextRepository;
            }
        }

        public BaseCRUDComplexKeyRepository<DialogTextTranslateDal> DialogTextTranslateRepository
        {
            get
            {
                if (_dialogTextTranslateRepository == null)
                {
                    _dialogTextTranslateRepository = new DialogTextTranslateRepository(_context);
                }

                return _dialogTextTranslateRepository;
            }
        }

        #endregion Dialogs

        #endregion Levels

        #region Tokens

        public BaseCRUDRepository<TokenDal, Int32> TokenRepository
        {
            get
            {
                if (_tokenRepository == null)
                {
                    _tokenRepository = new TokenRepository(_context);
                }

                return _tokenRepository;
            }
        }

        #endregion

        #region Languages

        public ILanguageRepository<LanguageDal, Int32> LanguageRepository
        {
            get
            {
                if (_languageRepository == null)
                {
                    _languageRepository = new LanguageRepository(_context);
                }

                return _languageRepository;
            }
        }

        #endregion Languages

        #endregion

        protected virtual void Dispose(Boolean disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        #region Fields

        private Boolean _disposed;
        private DbContext _context;

        private BaseCRURepository<UserDal, Int32> _userRepository;
        private IProjectRepository<ProjectDal, Int32> _projectRepository;
        private IPermissionRepository<PermissionDal, Int32> _permssionRepository;
        private IUserProjectPermissionRepository<UserProjectPermissionDal> _userProjectPermissionRepository;

        private IMenuRepository<MenuDal, Int32> _menuRepository;
        private IMenuTranslateRepository<MenuTranslateDal> _menuTranslateRepository;
        private IMenuAttributeRepository<MenuAttributeDal, Int32> _menuAttributeRepository;
        private IMenuAttributeValueRepository<MenuAttributeValueDal, Int32> _menuAttributeValueRepository;
        private IMenuAttributeTranslateRepository<MenuAttributeTranslateDal> _menuAttributeTranslateRepository;
        private IMenuAttributeValueTranslateRepository<MenuAttributeValueTranslateDal> _menuAttributeValueTranslateRepository;

        private ILevelRepository<LevelDal, Int32> _levelRepository;
        private ILevelDialogRepository<LevelDialogDal> _levelDialogRepository;
        private BaseCRUDComplexKeyRepository<LevelTranslateDal> _levelTranslateRepository;

        private BaseCRUDRepository<DialogDal, Int32> _dialogRepository;
        private BaseCRUDRepository<DialogTextDal, Int32> _dialogTextRepository;
        private BaseCRUDRepository<DialogRecordDal, Int32> _dialogRecordRepository;
        private BaseCRUDComplexKeyRepository<DialogTextTranslateDal> _dialogTextTranslateRepository;
        private BaseCRUDComplexKeyRepository<DialogRecordTranslateDal> _dialogRecordTranslateRepository;

        private BaseCRUDRepository<TokenDal, Int32> _tokenRepository;

        private ILanguageRepository<LanguageDal, Int32> _languageRepository;

        #endregion
    }
}
