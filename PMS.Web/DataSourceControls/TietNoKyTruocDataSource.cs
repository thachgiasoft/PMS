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
	/// Represents the DataRepository.TietNoKyTruocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TietNoKyTruocDataSourceDesigner))]
	public class TietNoKyTruocDataSource : ProviderDataSource<TietNoKyTruoc, TietNoKyTruocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TietNoKyTruocDataSource class.
		/// </summary>
		public TietNoKyTruocDataSource() : base(new TietNoKyTruocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TietNoKyTruocDataSourceView used by the TietNoKyTruocDataSource.
		/// </summary>
		protected TietNoKyTruocDataSourceView TietNoKyTruocView
		{
			get { return ( View as TietNoKyTruocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TietNoKyTruocDataSource control invokes to retrieve data.
		/// </summary>
		public TietNoKyTruocSelectMethod SelectMethod
		{
			get
			{
				TietNoKyTruocSelectMethod selectMethod = TietNoKyTruocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TietNoKyTruocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TietNoKyTruocDataSourceView class that is to be
		/// used by the TietNoKyTruocDataSource.
		/// </summary>
		/// <returns>An instance of the TietNoKyTruocDataSourceView class.</returns>
		protected override BaseDataSourceView<TietNoKyTruoc, TietNoKyTruocKey> GetNewDataSourceView()
		{
			return new TietNoKyTruocDataSourceView(this, DefaultViewName);
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
	/// Supports the TietNoKyTruocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TietNoKyTruocDataSourceView : ProviderDataSourceView<TietNoKyTruoc, TietNoKyTruocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TietNoKyTruocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TietNoKyTruocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TietNoKyTruocDataSourceView(TietNoKyTruocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TietNoKyTruocDataSource TietNoKyTruocOwner
		{
			get { return Owner as TietNoKyTruocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TietNoKyTruocSelectMethod SelectMethod
		{
			get { return TietNoKyTruocOwner.SelectMethod; }
			set { TietNoKyTruocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TietNoKyTruocService TietNoKyTruocProvider
		{
			get { return Provider as TietNoKyTruocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TietNoKyTruoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TietNoKyTruoc> results = null;
			TietNoKyTruoc item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case TietNoKyTruocSelectMethod.Get:
					TietNoKyTruocKey entityKey  = new TietNoKyTruocKey();
					entityKey.Load(values);
					item = TietNoKyTruocProvider.Get(entityKey);
					results = new TList<TietNoKyTruoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TietNoKyTruocSelectMethod.GetAll:
                    results = TietNoKyTruocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TietNoKyTruocSelectMethod.GetPaged:
					results = TietNoKyTruocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TietNoKyTruocSelectMethod.Find:
					if ( FilterParameters != null )
						results = TietNoKyTruocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TietNoKyTruocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TietNoKyTruocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = TietNoKyTruocProvider.GetById(_id);
					results = new TList<TietNoKyTruoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case TietNoKyTruocSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = TietNoKyTruocProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == TietNoKyTruocSelectMethod.Get || SelectMethod == TietNoKyTruocSelectMethod.GetById )
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
				TietNoKyTruoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TietNoKyTruocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TietNoKyTruoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TietNoKyTruocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TietNoKyTruocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TietNoKyTruocDataSource class.
	/// </summary>
	public class TietNoKyTruocDataSourceDesigner : ProviderDataSourceDesigner<TietNoKyTruoc, TietNoKyTruocKey>
	{
		/// <summary>
		/// Initializes a new instance of the TietNoKyTruocDataSourceDesigner class.
		/// </summary>
		public TietNoKyTruocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TietNoKyTruocSelectMethod SelectMethod
		{
			get { return ((TietNoKyTruocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TietNoKyTruocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TietNoKyTruocDataSourceActionList

	/// <summary>
	/// Supports the TietNoKyTruocDataSourceDesigner class.
	/// </summary>
	internal class TietNoKyTruocDataSourceActionList : DesignerActionList
	{
		private TietNoKyTruocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TietNoKyTruocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TietNoKyTruocDataSourceActionList(TietNoKyTruocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TietNoKyTruocSelectMethod SelectMethod
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

	#endregion TietNoKyTruocDataSourceActionList
	
	#endregion TietNoKyTruocDataSourceDesigner
	
	#region TietNoKyTruocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TietNoKyTruocDataSource.SelectMethod property.
	/// </summary>
	public enum TietNoKyTruocSelectMethod
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
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion TietNoKyTruocSelectMethod

	#region TietNoKyTruocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TietNoKyTruoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TietNoKyTruocFilter : SqlFilter<TietNoKyTruocColumn>
	{
	}
	
	#endregion TietNoKyTruocFilter

	#region TietNoKyTruocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TietNoKyTruoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TietNoKyTruocExpressionBuilder : SqlExpressionBuilder<TietNoKyTruocColumn>
	{
	}
	
	#endregion TietNoKyTruocExpressionBuilder	

	#region TietNoKyTruocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TietNoKyTruocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TietNoKyTruoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TietNoKyTruocProperty : ChildEntityProperty<TietNoKyTruocChildEntityTypes>
	{
	}
	
	#endregion TietNoKyTruocProperty
}

