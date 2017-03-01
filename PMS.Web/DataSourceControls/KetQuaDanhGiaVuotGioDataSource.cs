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
	/// Represents the DataRepository.KetQuaDanhGiaVuotGioProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KetQuaDanhGiaVuotGioDataSourceDesigner))]
	public class KetQuaDanhGiaVuotGioDataSource : ProviderDataSource<KetQuaDanhGiaVuotGio, KetQuaDanhGiaVuotGioKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioDataSource class.
		/// </summary>
		public KetQuaDanhGiaVuotGioDataSource() : base(new KetQuaDanhGiaVuotGioService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KetQuaDanhGiaVuotGioDataSourceView used by the KetQuaDanhGiaVuotGioDataSource.
		/// </summary>
		protected KetQuaDanhGiaVuotGioDataSourceView KetQuaDanhGiaVuotGioView
		{
			get { return ( View as KetQuaDanhGiaVuotGioDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KetQuaDanhGiaVuotGioDataSource control invokes to retrieve data.
		/// </summary>
		public KetQuaDanhGiaVuotGioSelectMethod SelectMethod
		{
			get
			{
				KetQuaDanhGiaVuotGioSelectMethod selectMethod = KetQuaDanhGiaVuotGioSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KetQuaDanhGiaVuotGioSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KetQuaDanhGiaVuotGioDataSourceView class that is to be
		/// used by the KetQuaDanhGiaVuotGioDataSource.
		/// </summary>
		/// <returns>An instance of the KetQuaDanhGiaVuotGioDataSourceView class.</returns>
		protected override BaseDataSourceView<KetQuaDanhGiaVuotGio, KetQuaDanhGiaVuotGioKey> GetNewDataSourceView()
		{
			return new KetQuaDanhGiaVuotGioDataSourceView(this, DefaultViewName);
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
	/// Supports the KetQuaDanhGiaVuotGioDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KetQuaDanhGiaVuotGioDataSourceView : ProviderDataSourceView<KetQuaDanhGiaVuotGio, KetQuaDanhGiaVuotGioKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KetQuaDanhGiaVuotGioDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KetQuaDanhGiaVuotGioDataSourceView(KetQuaDanhGiaVuotGioDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KetQuaDanhGiaVuotGioDataSource KetQuaDanhGiaVuotGioOwner
		{
			get { return Owner as KetQuaDanhGiaVuotGioDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KetQuaDanhGiaVuotGioSelectMethod SelectMethod
		{
			get { return KetQuaDanhGiaVuotGioOwner.SelectMethod; }
			set { KetQuaDanhGiaVuotGioOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KetQuaDanhGiaVuotGioService KetQuaDanhGiaVuotGioProvider
		{
			get { return Provider as KetQuaDanhGiaVuotGioService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KetQuaDanhGiaVuotGio> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KetQuaDanhGiaVuotGio> results = null;
			KetQuaDanhGiaVuotGio item;
			count = 0;
			
			System.Int32 _id;
			System.String _maNoiDungDanhGia_nullable;

			switch ( SelectMethod )
			{
				case KetQuaDanhGiaVuotGioSelectMethod.Get:
					KetQuaDanhGiaVuotGioKey entityKey  = new KetQuaDanhGiaVuotGioKey();
					entityKey.Load(values);
					item = KetQuaDanhGiaVuotGioProvider.Get(entityKey);
					results = new TList<KetQuaDanhGiaVuotGio>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KetQuaDanhGiaVuotGioSelectMethod.GetAll:
                    results = KetQuaDanhGiaVuotGioProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KetQuaDanhGiaVuotGioSelectMethod.GetPaged:
					results = KetQuaDanhGiaVuotGioProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KetQuaDanhGiaVuotGioSelectMethod.Find:
					if ( FilterParameters != null )
						results = KetQuaDanhGiaVuotGioProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KetQuaDanhGiaVuotGioProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KetQuaDanhGiaVuotGioSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KetQuaDanhGiaVuotGioProvider.GetById(_id);
					results = new TList<KetQuaDanhGiaVuotGio>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KetQuaDanhGiaVuotGioSelectMethod.GetByMaNoiDungDanhGia:
					_maNoiDungDanhGia_nullable = (System.String) EntityUtil.ChangeType(values["MaNoiDungDanhGia"], typeof(System.String));
					results = KetQuaDanhGiaVuotGioProvider.GetByMaNoiDungDanhGia(_maNoiDungDanhGia_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
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
			if ( SelectMethod == KetQuaDanhGiaVuotGioSelectMethod.Get || SelectMethod == KetQuaDanhGiaVuotGioSelectMethod.GetById )
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
				KetQuaDanhGiaVuotGio entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KetQuaDanhGiaVuotGioProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KetQuaDanhGiaVuotGio> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KetQuaDanhGiaVuotGioProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KetQuaDanhGiaVuotGioDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KetQuaDanhGiaVuotGioDataSource class.
	/// </summary>
	public class KetQuaDanhGiaVuotGioDataSourceDesigner : ProviderDataSourceDesigner<KetQuaDanhGiaVuotGio, KetQuaDanhGiaVuotGioKey>
	{
		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioDataSourceDesigner class.
		/// </summary>
		public KetQuaDanhGiaVuotGioDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaDanhGiaVuotGioSelectMethod SelectMethod
		{
			get { return ((KetQuaDanhGiaVuotGioDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KetQuaDanhGiaVuotGioDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KetQuaDanhGiaVuotGioDataSourceActionList

	/// <summary>
	/// Supports the KetQuaDanhGiaVuotGioDataSourceDesigner class.
	/// </summary>
	internal class KetQuaDanhGiaVuotGioDataSourceActionList : DesignerActionList
	{
		private KetQuaDanhGiaVuotGioDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KetQuaDanhGiaVuotGioDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KetQuaDanhGiaVuotGioDataSourceActionList(KetQuaDanhGiaVuotGioDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaDanhGiaVuotGioSelectMethod SelectMethod
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

	#endregion KetQuaDanhGiaVuotGioDataSourceActionList
	
	#endregion KetQuaDanhGiaVuotGioDataSourceDesigner
	
	#region KetQuaDanhGiaVuotGioSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KetQuaDanhGiaVuotGioDataSource.SelectMethod property.
	/// </summary>
	public enum KetQuaDanhGiaVuotGioSelectMethod
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
		/// Represents the GetByMaNoiDungDanhGia method.
		/// </summary>
		GetByMaNoiDungDanhGia
	}
	
	#endregion KetQuaDanhGiaVuotGioSelectMethod

	#region KetQuaDanhGiaVuotGioFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaDanhGiaVuotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaDanhGiaVuotGioFilter : SqlFilter<KetQuaDanhGiaVuotGioColumn>
	{
	}
	
	#endregion KetQuaDanhGiaVuotGioFilter

	#region KetQuaDanhGiaVuotGioExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaDanhGiaVuotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaDanhGiaVuotGioExpressionBuilder : SqlExpressionBuilder<KetQuaDanhGiaVuotGioColumn>
	{
	}
	
	#endregion KetQuaDanhGiaVuotGioExpressionBuilder	

	#region KetQuaDanhGiaVuotGioProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KetQuaDanhGiaVuotGioChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaDanhGiaVuotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaDanhGiaVuotGioProperty : ChildEntityProperty<KetQuaDanhGiaVuotGioChildEntityTypes>
	{
	}
	
	#endregion KetQuaDanhGiaVuotGioProperty
}

