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
	/// Represents the DataRepository.SoTietNckhChuyenSangNamSauProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SoTietNckhChuyenSangNamSauDataSourceDesigner))]
	public class SoTietNckhChuyenSangNamSauDataSource : ProviderDataSource<SoTietNckhChuyenSangNamSau, SoTietNckhChuyenSangNamSauKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SoTietNckhChuyenSangNamSauDataSource class.
		/// </summary>
		public SoTietNckhChuyenSangNamSauDataSource() : base(new SoTietNckhChuyenSangNamSauService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SoTietNckhChuyenSangNamSauDataSourceView used by the SoTietNckhChuyenSangNamSauDataSource.
		/// </summary>
		protected SoTietNckhChuyenSangNamSauDataSourceView SoTietNckhChuyenSangNamSauView
		{
			get { return ( View as SoTietNckhChuyenSangNamSauDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SoTietNckhChuyenSangNamSauDataSource control invokes to retrieve data.
		/// </summary>
		public SoTietNckhChuyenSangNamSauSelectMethod SelectMethod
		{
			get
			{
				SoTietNckhChuyenSangNamSauSelectMethod selectMethod = SoTietNckhChuyenSangNamSauSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SoTietNckhChuyenSangNamSauSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SoTietNckhChuyenSangNamSauDataSourceView class that is to be
		/// used by the SoTietNckhChuyenSangNamSauDataSource.
		/// </summary>
		/// <returns>An instance of the SoTietNckhChuyenSangNamSauDataSourceView class.</returns>
		protected override BaseDataSourceView<SoTietNckhChuyenSangNamSau, SoTietNckhChuyenSangNamSauKey> GetNewDataSourceView()
		{
			return new SoTietNckhChuyenSangNamSauDataSourceView(this, DefaultViewName);
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
	/// Supports the SoTietNckhChuyenSangNamSauDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SoTietNckhChuyenSangNamSauDataSourceView : ProviderDataSourceView<SoTietNckhChuyenSangNamSau, SoTietNckhChuyenSangNamSauKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SoTietNckhChuyenSangNamSauDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SoTietNckhChuyenSangNamSauDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SoTietNckhChuyenSangNamSauDataSourceView(SoTietNckhChuyenSangNamSauDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SoTietNckhChuyenSangNamSauDataSource SoTietNckhChuyenSangNamSauOwner
		{
			get { return Owner as SoTietNckhChuyenSangNamSauDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SoTietNckhChuyenSangNamSauSelectMethod SelectMethod
		{
			get { return SoTietNckhChuyenSangNamSauOwner.SelectMethod; }
			set { SoTietNckhChuyenSangNamSauOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SoTietNckhChuyenSangNamSauService SoTietNckhChuyenSangNamSauProvider
		{
			get { return Provider as SoTietNckhChuyenSangNamSauService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SoTietNckhChuyenSangNamSau> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SoTietNckhChuyenSangNamSau> results = null;
			SoTietNckhChuyenSangNamSau item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case SoTietNckhChuyenSangNamSauSelectMethod.Get:
					SoTietNckhChuyenSangNamSauKey entityKey  = new SoTietNckhChuyenSangNamSauKey();
					entityKey.Load(values);
					item = SoTietNckhChuyenSangNamSauProvider.Get(entityKey);
					results = new TList<SoTietNckhChuyenSangNamSau>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SoTietNckhChuyenSangNamSauSelectMethod.GetAll:
                    results = SoTietNckhChuyenSangNamSauProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SoTietNckhChuyenSangNamSauSelectMethod.GetPaged:
					results = SoTietNckhChuyenSangNamSauProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SoTietNckhChuyenSangNamSauSelectMethod.Find:
					if ( FilterParameters != null )
						results = SoTietNckhChuyenSangNamSauProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SoTietNckhChuyenSangNamSauProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SoTietNckhChuyenSangNamSauSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SoTietNckhChuyenSangNamSauProvider.GetById(_id);
					results = new TList<SoTietNckhChuyenSangNamSau>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == SoTietNckhChuyenSangNamSauSelectMethod.Get || SelectMethod == SoTietNckhChuyenSangNamSauSelectMethod.GetById )
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
				SoTietNckhChuyenSangNamSau entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SoTietNckhChuyenSangNamSauProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SoTietNckhChuyenSangNamSau> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SoTietNckhChuyenSangNamSauProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SoTietNckhChuyenSangNamSauDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SoTietNckhChuyenSangNamSauDataSource class.
	/// </summary>
	public class SoTietNckhChuyenSangNamSauDataSourceDesigner : ProviderDataSourceDesigner<SoTietNckhChuyenSangNamSau, SoTietNckhChuyenSangNamSauKey>
	{
		/// <summary>
		/// Initializes a new instance of the SoTietNckhChuyenSangNamSauDataSourceDesigner class.
		/// </summary>
		public SoTietNckhChuyenSangNamSauDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SoTietNckhChuyenSangNamSauSelectMethod SelectMethod
		{
			get { return ((SoTietNckhChuyenSangNamSauDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SoTietNckhChuyenSangNamSauDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SoTietNckhChuyenSangNamSauDataSourceActionList

	/// <summary>
	/// Supports the SoTietNckhChuyenSangNamSauDataSourceDesigner class.
	/// </summary>
	internal class SoTietNckhChuyenSangNamSauDataSourceActionList : DesignerActionList
	{
		private SoTietNckhChuyenSangNamSauDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SoTietNckhChuyenSangNamSauDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SoTietNckhChuyenSangNamSauDataSourceActionList(SoTietNckhChuyenSangNamSauDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SoTietNckhChuyenSangNamSauSelectMethod SelectMethod
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

	#endregion SoTietNckhChuyenSangNamSauDataSourceActionList
	
	#endregion SoTietNckhChuyenSangNamSauDataSourceDesigner
	
	#region SoTietNckhChuyenSangNamSauSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SoTietNckhChuyenSangNamSauDataSource.SelectMethod property.
	/// </summary>
	public enum SoTietNckhChuyenSangNamSauSelectMethod
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
		GetById
	}
	
	#endregion SoTietNckhChuyenSangNamSauSelectMethod

	#region SoTietNckhChuyenSangNamSauFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SoTietNckhChuyenSangNamSau"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SoTietNckhChuyenSangNamSauFilter : SqlFilter<SoTietNckhChuyenSangNamSauColumn>
	{
	}
	
	#endregion SoTietNckhChuyenSangNamSauFilter

	#region SoTietNckhChuyenSangNamSauExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SoTietNckhChuyenSangNamSau"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SoTietNckhChuyenSangNamSauExpressionBuilder : SqlExpressionBuilder<SoTietNckhChuyenSangNamSauColumn>
	{
	}
	
	#endregion SoTietNckhChuyenSangNamSauExpressionBuilder	

	#region SoTietNckhChuyenSangNamSauProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SoTietNckhChuyenSangNamSauChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SoTietNckhChuyenSangNamSau"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SoTietNckhChuyenSangNamSauProperty : ChildEntityProperty<SoTietNckhChuyenSangNamSauChildEntityTypes>
	{
	}
	
	#endregion SoTietNckhChuyenSangNamSauProperty
}

