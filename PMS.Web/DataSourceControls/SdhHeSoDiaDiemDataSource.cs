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
	/// Represents the DataRepository.SdhHeSoDiaDiemProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhHeSoDiaDiemDataSourceDesigner))]
	public class SdhHeSoDiaDiemDataSource : ProviderDataSource<SdhHeSoDiaDiem, SdhHeSoDiaDiemKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhHeSoDiaDiemDataSource class.
		/// </summary>
		public SdhHeSoDiaDiemDataSource() : base(new SdhHeSoDiaDiemService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhHeSoDiaDiemDataSourceView used by the SdhHeSoDiaDiemDataSource.
		/// </summary>
		protected SdhHeSoDiaDiemDataSourceView SdhHeSoDiaDiemView
		{
			get { return ( View as SdhHeSoDiaDiemDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhHeSoDiaDiemDataSource control invokes to retrieve data.
		/// </summary>
		public SdhHeSoDiaDiemSelectMethod SelectMethod
		{
			get
			{
				SdhHeSoDiaDiemSelectMethod selectMethod = SdhHeSoDiaDiemSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhHeSoDiaDiemSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhHeSoDiaDiemDataSourceView class that is to be
		/// used by the SdhHeSoDiaDiemDataSource.
		/// </summary>
		/// <returns>An instance of the SdhHeSoDiaDiemDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhHeSoDiaDiem, SdhHeSoDiaDiemKey> GetNewDataSourceView()
		{
			return new SdhHeSoDiaDiemDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhHeSoDiaDiemDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhHeSoDiaDiemDataSourceView : ProviderDataSourceView<SdhHeSoDiaDiem, SdhHeSoDiaDiemKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhHeSoDiaDiemDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhHeSoDiaDiemDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhHeSoDiaDiemDataSourceView(SdhHeSoDiaDiemDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhHeSoDiaDiemDataSource SdhHeSoDiaDiemOwner
		{
			get { return Owner as SdhHeSoDiaDiemDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhHeSoDiaDiemSelectMethod SelectMethod
		{
			get { return SdhHeSoDiaDiemOwner.SelectMethod; }
			set { SdhHeSoDiaDiemOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhHeSoDiaDiemService SdhHeSoDiaDiemProvider
		{
			get { return Provider as SdhHeSoDiaDiemService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhHeSoDiaDiem> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhHeSoDiaDiem> results = null;
			SdhHeSoDiaDiem item;
			count = 0;
			
			System.Int32 _maHeSo;

			switch ( SelectMethod )
			{
				case SdhHeSoDiaDiemSelectMethod.Get:
					SdhHeSoDiaDiemKey entityKey  = new SdhHeSoDiaDiemKey();
					entityKey.Load(values);
					item = SdhHeSoDiaDiemProvider.Get(entityKey);
					results = new TList<SdhHeSoDiaDiem>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhHeSoDiaDiemSelectMethod.GetAll:
                    results = SdhHeSoDiaDiemProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhHeSoDiaDiemSelectMethod.GetPaged:
					results = SdhHeSoDiaDiemProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhHeSoDiaDiemSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhHeSoDiaDiemProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhHeSoDiaDiemProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhHeSoDiaDiemSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = SdhHeSoDiaDiemProvider.GetByMaHeSo(_maHeSo);
					results = new TList<SdhHeSoDiaDiem>();
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
			if ( SelectMethod == SdhHeSoDiaDiemSelectMethod.Get || SelectMethod == SdhHeSoDiaDiemSelectMethod.GetByMaHeSo )
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
				SdhHeSoDiaDiem entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhHeSoDiaDiemProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhHeSoDiaDiem> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhHeSoDiaDiemProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhHeSoDiaDiemDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhHeSoDiaDiemDataSource class.
	/// </summary>
	public class SdhHeSoDiaDiemDataSourceDesigner : ProviderDataSourceDesigner<SdhHeSoDiaDiem, SdhHeSoDiaDiemKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhHeSoDiaDiemDataSourceDesigner class.
		/// </summary>
		public SdhHeSoDiaDiemDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhHeSoDiaDiemSelectMethod SelectMethod
		{
			get { return ((SdhHeSoDiaDiemDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhHeSoDiaDiemDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhHeSoDiaDiemDataSourceActionList

	/// <summary>
	/// Supports the SdhHeSoDiaDiemDataSourceDesigner class.
	/// </summary>
	internal class SdhHeSoDiaDiemDataSourceActionList : DesignerActionList
	{
		private SdhHeSoDiaDiemDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhHeSoDiaDiemDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhHeSoDiaDiemDataSourceActionList(SdhHeSoDiaDiemDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhHeSoDiaDiemSelectMethod SelectMethod
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

	#endregion SdhHeSoDiaDiemDataSourceActionList
	
	#endregion SdhHeSoDiaDiemDataSourceDesigner
	
	#region SdhHeSoDiaDiemSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhHeSoDiaDiemDataSource.SelectMethod property.
	/// </summary>
	public enum SdhHeSoDiaDiemSelectMethod
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
		/// Represents the GetByMaHeSo method.
		/// </summary>
		GetByMaHeSo
	}
	
	#endregion SdhHeSoDiaDiemSelectMethod

	#region SdhHeSoDiaDiemFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhHeSoDiaDiem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhHeSoDiaDiemFilter : SqlFilter<SdhHeSoDiaDiemColumn>
	{
	}
	
	#endregion SdhHeSoDiaDiemFilter

	#region SdhHeSoDiaDiemExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhHeSoDiaDiem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhHeSoDiaDiemExpressionBuilder : SqlExpressionBuilder<SdhHeSoDiaDiemColumn>
	{
	}
	
	#endregion SdhHeSoDiaDiemExpressionBuilder	

	#region SdhHeSoDiaDiemProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhHeSoDiaDiemChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhHeSoDiaDiem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhHeSoDiaDiemProperty : ChildEntityProperty<SdhHeSoDiaDiemChildEntityTypes>
	{
	}
	
	#endregion SdhHeSoDiaDiemProperty
}

