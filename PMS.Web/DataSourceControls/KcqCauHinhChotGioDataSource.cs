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
	/// Represents the DataRepository.KcqCauHinhChotGioProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqCauHinhChotGioDataSourceDesigner))]
	public class KcqCauHinhChotGioDataSource : ProviderDataSource<KcqCauHinhChotGio, KcqCauHinhChotGioKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioDataSource class.
		/// </summary>
		public KcqCauHinhChotGioDataSource() : base(new KcqCauHinhChotGioService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqCauHinhChotGioDataSourceView used by the KcqCauHinhChotGioDataSource.
		/// </summary>
		protected KcqCauHinhChotGioDataSourceView KcqCauHinhChotGioView
		{
			get { return ( View as KcqCauHinhChotGioDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqCauHinhChotGioDataSource control invokes to retrieve data.
		/// </summary>
		public KcqCauHinhChotGioSelectMethod SelectMethod
		{
			get
			{
				KcqCauHinhChotGioSelectMethod selectMethod = KcqCauHinhChotGioSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqCauHinhChotGioSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqCauHinhChotGioDataSourceView class that is to be
		/// used by the KcqCauHinhChotGioDataSource.
		/// </summary>
		/// <returns>An instance of the KcqCauHinhChotGioDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqCauHinhChotGio, KcqCauHinhChotGioKey> GetNewDataSourceView()
		{
			return new KcqCauHinhChotGioDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqCauHinhChotGioDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqCauHinhChotGioDataSourceView : ProviderDataSourceView<KcqCauHinhChotGio, KcqCauHinhChotGioKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqCauHinhChotGioDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqCauHinhChotGioDataSourceView(KcqCauHinhChotGioDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqCauHinhChotGioDataSource KcqCauHinhChotGioOwner
		{
			get { return Owner as KcqCauHinhChotGioDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqCauHinhChotGioSelectMethod SelectMethod
		{
			get { return KcqCauHinhChotGioOwner.SelectMethod; }
			set { KcqCauHinhChotGioOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqCauHinhChotGioService KcqCauHinhChotGioProvider
		{
			get { return Provider as KcqCauHinhChotGioService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqCauHinhChotGio> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqCauHinhChotGio> results = null;
			KcqCauHinhChotGio item;
			count = 0;
			
			System.Int32 _maCauHinhChotGio;
			System.String sp349_NamHoc;
			System.String sp349_Dot;
			System.String sp350_NamHoc;
			System.String sp350_HocKy;

			switch ( SelectMethod )
			{
				case KcqCauHinhChotGioSelectMethod.Get:
					KcqCauHinhChotGioKey entityKey  = new KcqCauHinhChotGioKey();
					entityKey.Load(values);
					item = KcqCauHinhChotGioProvider.Get(entityKey);
					results = new TList<KcqCauHinhChotGio>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqCauHinhChotGioSelectMethod.GetAll:
                    results = KcqCauHinhChotGioProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqCauHinhChotGioSelectMethod.GetPaged:
					results = KcqCauHinhChotGioProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqCauHinhChotGioSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqCauHinhChotGioProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqCauHinhChotGioProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqCauHinhChotGioSelectMethod.GetByMaCauHinhChotGio:
					_maCauHinhChotGio = ( values["MaCauHinhChotGio"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaCauHinhChotGio"], typeof(System.Int32)) : (int)0;
					item = KcqCauHinhChotGioProvider.GetByMaCauHinhChotGio(_maCauHinhChotGio);
					results = new TList<KcqCauHinhChotGio>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KcqCauHinhChotGioSelectMethod.GetByNamHocDot:
					sp349_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp349_Dot = (System.String) EntityUtil.ChangeType(values["Dot"], typeof(System.String));
					results = KcqCauHinhChotGioProvider.GetByNamHocDot(sp349_NamHoc, sp349_Dot, StartIndex, PageSize);
					break;
				case KcqCauHinhChotGioSelectMethod.GetByNamHocHocKy:
					sp350_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp350_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KcqCauHinhChotGioProvider.GetByNamHocHocKy(sp350_NamHoc, sp350_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == KcqCauHinhChotGioSelectMethod.Get || SelectMethod == KcqCauHinhChotGioSelectMethod.GetByMaCauHinhChotGio )
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
				KcqCauHinhChotGio entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqCauHinhChotGioProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqCauHinhChotGio> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqCauHinhChotGioProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqCauHinhChotGioDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqCauHinhChotGioDataSource class.
	/// </summary>
	public class KcqCauHinhChotGioDataSourceDesigner : ProviderDataSourceDesigner<KcqCauHinhChotGio, KcqCauHinhChotGioKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioDataSourceDesigner class.
		/// </summary>
		public KcqCauHinhChotGioDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqCauHinhChotGioSelectMethod SelectMethod
		{
			get { return ((KcqCauHinhChotGioDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqCauHinhChotGioDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqCauHinhChotGioDataSourceActionList

	/// <summary>
	/// Supports the KcqCauHinhChotGioDataSourceDesigner class.
	/// </summary>
	internal class KcqCauHinhChotGioDataSourceActionList : DesignerActionList
	{
		private KcqCauHinhChotGioDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqCauHinhChotGioDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqCauHinhChotGioDataSourceActionList(KcqCauHinhChotGioDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqCauHinhChotGioSelectMethod SelectMethod
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

	#endregion KcqCauHinhChotGioDataSourceActionList
	
	#endregion KcqCauHinhChotGioDataSourceDesigner
	
	#region KcqCauHinhChotGioSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqCauHinhChotGioDataSource.SelectMethod property.
	/// </summary>
	public enum KcqCauHinhChotGioSelectMethod
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
		/// Represents the GetByMaCauHinhChotGio method.
		/// </summary>
		GetByMaCauHinhChotGio,
		/// <summary>
		/// Represents the GetByNamHocDot method.
		/// </summary>
		GetByNamHocDot,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion KcqCauHinhChotGioSelectMethod

	#region KcqCauHinhChotGioFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqCauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqCauHinhChotGioFilter : SqlFilter<KcqCauHinhChotGioColumn>
	{
	}
	
	#endregion KcqCauHinhChotGioFilter

	#region KcqCauHinhChotGioExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqCauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqCauHinhChotGioExpressionBuilder : SqlExpressionBuilder<KcqCauHinhChotGioColumn>
	{
	}
	
	#endregion KcqCauHinhChotGioExpressionBuilder	

	#region KcqCauHinhChotGioProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqCauHinhChotGioChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqCauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqCauHinhChotGioProperty : ChildEntityProperty<KcqCauHinhChotGioChildEntityTypes>
	{
	}
	
	#endregion KcqCauHinhChotGioProperty
}

