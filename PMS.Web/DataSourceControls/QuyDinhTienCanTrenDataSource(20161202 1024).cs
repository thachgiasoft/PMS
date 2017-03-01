#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.QuyDinhTienCanTrenProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(QuyDinhTienCanTrenDataSourceDesigner))]
	public class QuyDinhTienCanTrenDataSource : ProviderDataSource<QuyDinhTienCanTren, QuyDinhTienCanTrenKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenDataSource class.
		/// </summary>
		public QuyDinhTienCanTrenDataSource() : base(new QuyDinhTienCanTrenService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the QuyDinhTienCanTrenDataSourceView used by the QuyDinhTienCanTrenDataSource.
		/// </summary>
		protected QuyDinhTienCanTrenDataSourceView QuyDinhTienCanTrenView
		{
			get { return ( View as QuyDinhTienCanTrenDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the QuyDinhTienCanTrenDataSource control invokes to retrieve data.
		/// </summary>
		public QuyDinhTienCanTrenSelectMethod SelectMethod
		{
			get
			{
				QuyDinhTienCanTrenSelectMethod selectMethod = QuyDinhTienCanTrenSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (QuyDinhTienCanTrenSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the QuyDinhTienCanTrenDataSourceView class that is to be
		/// used by the QuyDinhTienCanTrenDataSource.
		/// </summary>
		/// <returns>An instance of the QuyDinhTienCanTrenDataSourceView class.</returns>
		protected override BaseDataSourceView<QuyDinhTienCanTren, QuyDinhTienCanTrenKey> GetNewDataSourceView()
		{
			return new QuyDinhTienCanTrenDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the QuyDinhTienCanTrenDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class QuyDinhTienCanTrenDataSourceView : ProviderDataSourceView<QuyDinhTienCanTren, QuyDinhTienCanTrenKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the QuyDinhTienCanTrenDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public QuyDinhTienCanTrenDataSourceView(QuyDinhTienCanTrenDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal QuyDinhTienCanTrenDataSource QuyDinhTienCanTrenOwner
		{
			get { return Owner as QuyDinhTienCanTrenDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal QuyDinhTienCanTrenSelectMethod SelectMethod
		{
			get { return QuyDinhTienCanTrenOwner.SelectMethod; }
			set { QuyDinhTienCanTrenOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal QuyDinhTienCanTrenService QuyDinhTienCanTrenProvider
		{
			get { return Provider as QuyDinhTienCanTrenService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<QuyDinhTienCanTren> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<QuyDinhTienCanTren> results = null;
			QuyDinhTienCanTren item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maHocHam_nullable;
			System.Int32? _maHocVi_nullable;
			System.Int32? _maLoaiGiangVien_nullable;
			System.Int32? _maLoaiNhanVien_nullable;
			System.String sp2801_NamHoc;
			System.String sp2801_HocKy;

			switch ( SelectMethod )
			{
				case QuyDinhTienCanTrenSelectMethod.Get:
					QuyDinhTienCanTrenKey entityKey  = new QuyDinhTienCanTrenKey();
					entityKey.Load(values);
					item = QuyDinhTienCanTrenProvider.Get(entityKey);
					results = new TList<QuyDinhTienCanTren>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case QuyDinhTienCanTrenSelectMethod.GetAll:
                    results = QuyDinhTienCanTrenProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case QuyDinhTienCanTrenSelectMethod.GetPaged:
					results = QuyDinhTienCanTrenProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case QuyDinhTienCanTrenSelectMethod.Find:
					if ( FilterParameters != null )
						results = QuyDinhTienCanTrenProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = QuyDinhTienCanTrenProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case QuyDinhTienCanTrenSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = QuyDinhTienCanTrenProvider.GetById(_id);
					results = new TList<QuyDinhTienCanTren>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case QuyDinhTienCanTrenSelectMethod.GetByMaHocHam:
					_maHocHam_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32?));
					results = QuyDinhTienCanTrenProvider.GetByMaHocHam(_maHocHam_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case QuyDinhTienCanTrenSelectMethod.GetByMaHocVi:
					_maHocVi_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32?));
					results = QuyDinhTienCanTrenProvider.GetByMaHocVi(_maHocVi_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case QuyDinhTienCanTrenSelectMethod.GetByMaLoaiGiangVien:
					_maLoaiGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32?));
					results = QuyDinhTienCanTrenProvider.GetByMaLoaiGiangVien(_maLoaiGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case QuyDinhTienCanTrenSelectMethod.GetByMaLoaiNhanVien:
					_maLoaiNhanVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaLoaiNhanVien"], typeof(System.Int32?));
					results = QuyDinhTienCanTrenProvider.GetByMaLoaiNhanVien(_maLoaiNhanVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case QuyDinhTienCanTrenSelectMethod.GetByNamHocHocKy:
					sp2801_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2801_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = QuyDinhTienCanTrenProvider.GetByNamHocHocKy(sp2801_NamHoc, sp2801_HocKy, StartIndex, PageSize);
					break;
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == QuyDinhTienCanTrenSelectMethod.Get || SelectMethod == QuyDinhTienCanTrenSelectMethod.GetById )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				QuyDinhTienCanTren entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					QuyDinhTienCanTrenProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<QuyDinhTienCanTren> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			QuyDinhTienCanTrenProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region QuyDinhTienCanTrenDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the QuyDinhTienCanTrenDataSource class.
	/// </summary>
	public class QuyDinhTienCanTrenDataSourceDesigner : ProviderDataSourceDesigner<QuyDinhTienCanTren, QuyDinhTienCanTrenKey>
	{
		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenDataSourceDesigner class.
		/// </summary>
		public QuyDinhTienCanTrenDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyDinhTienCanTrenSelectMethod SelectMethod
		{
			get { return ((QuyDinhTienCanTrenDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new QuyDinhTienCanTrenDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region QuyDinhTienCanTrenDataSourceActionList

	/// <summary>
	/// Supports the QuyDinhTienCanTrenDataSourceDesigner class.
	/// </summary>
	internal class QuyDinhTienCanTrenDataSourceActionList : DesignerActionList
	{
		private QuyDinhTienCanTrenDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the QuyDinhTienCanTrenDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public QuyDinhTienCanTrenDataSourceActionList(QuyDinhTienCanTrenDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyDinhTienCanTrenSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion QuyDinhTienCanTrenDataSourceActionList
	
	#endregion QuyDinhTienCanTrenDataSourceDesigner
	
	#region QuyDinhTienCanTrenSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the QuyDinhTienCanTrenDataSource.SelectMethod property.
	/// </summary>
	public enum QuyDinhTienCanTrenSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByMaHocHam method.
		/// </summary>
		GetByMaHocHam,
		/// <summary>
		/// Represents the GetByMaHocVi method.
		/// </summary>
		GetByMaHocVi,
		/// <summary>
		/// Represents the GetByMaLoaiGiangVien method.
		/// </summary>
		GetByMaLoaiGiangVien,
		/// <summary>
		/// Represents the GetByMaLoaiNhanVien method.
		/// </summary>
		GetByMaLoaiNhanVien,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion QuyDinhTienCanTrenSelectMethod

	#region QuyDinhTienCanTrenFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDinhTienCanTren"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDinhTienCanTrenFilter : SqlFilter<QuyDinhTienCanTrenColumn>
	{
	}
	
	#endregion QuyDinhTienCanTrenFilter

	#region QuyDinhTienCanTrenExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDinhTienCanTren"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDinhTienCanTrenExpressionBuilder : SqlExpressionBuilder<QuyDinhTienCanTrenColumn>
	{
	}
	
	#endregion QuyDinhTienCanTrenExpressionBuilder	

	#region QuyDinhTienCanTrenProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;QuyDinhTienCanTrenChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDinhTienCanTren"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDinhTienCanTrenProperty : ChildEntityProperty<QuyDinhTienCanTrenChildEntityTypes>
	{
	}
	
	#endregion QuyDinhTienCanTrenProperty
}

