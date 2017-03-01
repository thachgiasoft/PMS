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
	/// Represents the DataRepository.TietNghiaVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TietNghiaVuDataSourceDesigner))]
	public class TietNghiaVuDataSource : ProviderDataSource<TietNghiaVu, TietNghiaVuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuDataSource class.
		/// </summary>
		public TietNghiaVuDataSource() : base(new TietNghiaVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TietNghiaVuDataSourceView used by the TietNghiaVuDataSource.
		/// </summary>
		protected TietNghiaVuDataSourceView TietNghiaVuView
		{
			get { return ( View as TietNghiaVuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TietNghiaVuDataSource control invokes to retrieve data.
		/// </summary>
		public TietNghiaVuSelectMethod SelectMethod
		{
			get
			{
				TietNghiaVuSelectMethod selectMethod = TietNghiaVuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TietNghiaVuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TietNghiaVuDataSourceView class that is to be
		/// used by the TietNghiaVuDataSource.
		/// </summary>
		/// <returns>An instance of the TietNghiaVuDataSourceView class.</returns>
		protected override BaseDataSourceView<TietNghiaVu, TietNghiaVuKey> GetNewDataSourceView()
		{
			return new TietNghiaVuDataSourceView(this, DefaultViewName);
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
	/// Supports the TietNghiaVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TietNghiaVuDataSourceView : ProviderDataSourceView<TietNghiaVu, TietNghiaVuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TietNghiaVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TietNghiaVuDataSourceView(TietNghiaVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TietNghiaVuDataSource TietNghiaVuOwner
		{
			get { return Owner as TietNghiaVuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TietNghiaVuSelectMethod SelectMethod
		{
			get { return TietNghiaVuOwner.SelectMethod; }
			set { TietNghiaVuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TietNghiaVuService TietNghiaVuProvider
		{
			get { return Provider as TietNghiaVuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TietNghiaVu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TietNghiaVu> results = null;
			TietNghiaVu item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maGiamTruKhac_nullable;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case TietNghiaVuSelectMethod.Get:
					TietNghiaVuKey entityKey  = new TietNghiaVuKey();
					entityKey.Load(values);
					item = TietNghiaVuProvider.Get(entityKey);
					results = new TList<TietNghiaVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TietNghiaVuSelectMethod.GetAll:
                    results = TietNghiaVuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TietNghiaVuSelectMethod.GetPaged:
					results = TietNghiaVuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TietNghiaVuSelectMethod.Find:
					if ( FilterParameters != null )
						results = TietNghiaVuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TietNghiaVuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TietNghiaVuSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = TietNghiaVuProvider.GetById(_id);
					results = new TList<TietNghiaVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case TietNghiaVuSelectMethod.GetByMaGiamTruKhac:
					_maGiamTruKhac_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiamTruKhac"], typeof(System.Int32?));
					results = TietNghiaVuProvider.GetByMaGiamTruKhac(_maGiamTruKhac_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case TietNghiaVuSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = TietNghiaVuProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == TietNghiaVuSelectMethod.Get || SelectMethod == TietNghiaVuSelectMethod.GetById )
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
				TietNghiaVu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TietNghiaVuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TietNghiaVu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TietNghiaVuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TietNghiaVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TietNghiaVuDataSource class.
	/// </summary>
	public class TietNghiaVuDataSourceDesigner : ProviderDataSourceDesigner<TietNghiaVu, TietNghiaVuKey>
	{
		/// <summary>
		/// Initializes a new instance of the TietNghiaVuDataSourceDesigner class.
		/// </summary>
		public TietNghiaVuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TietNghiaVuSelectMethod SelectMethod
		{
			get { return ((TietNghiaVuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TietNghiaVuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TietNghiaVuDataSourceActionList

	/// <summary>
	/// Supports the TietNghiaVuDataSourceDesigner class.
	/// </summary>
	internal class TietNghiaVuDataSourceActionList : DesignerActionList
	{
		private TietNghiaVuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TietNghiaVuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TietNghiaVuDataSourceActionList(TietNghiaVuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TietNghiaVuSelectMethod SelectMethod
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

	#endregion TietNghiaVuDataSourceActionList
	
	#endregion TietNghiaVuDataSourceDesigner
	
	#region TietNghiaVuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TietNghiaVuDataSource.SelectMethod property.
	/// </summary>
	public enum TietNghiaVuSelectMethod
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
		/// Represents the GetByMaGiamTruKhac method.
		/// </summary>
		GetByMaGiamTruKhac,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion TietNghiaVuSelectMethod

	#region TietNghiaVuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TietNghiaVuFilter : SqlFilter<TietNghiaVuColumn>
	{
	}
	
	#endregion TietNghiaVuFilter

	#region TietNghiaVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TietNghiaVuExpressionBuilder : SqlExpressionBuilder<TietNghiaVuColumn>
	{
	}
	
	#endregion TietNghiaVuExpressionBuilder	

	#region TietNghiaVuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TietNghiaVuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TietNghiaVuProperty : ChildEntityProperty<TietNghiaVuChildEntityTypes>
	{
	}
	
	#endregion TietNghiaVuProperty
}

