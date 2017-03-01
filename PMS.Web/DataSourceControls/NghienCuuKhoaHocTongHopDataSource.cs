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
	/// Represents the DataRepository.NghienCuuKhoaHocTongHopProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NghienCuuKhoaHocTongHopDataSourceDesigner))]
	public class NghienCuuKhoaHocTongHopDataSource : ProviderDataSource<NghienCuuKhoaHocTongHop, NghienCuuKhoaHocTongHopKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocTongHopDataSource class.
		/// </summary>
		public NghienCuuKhoaHocTongHopDataSource() : base(new NghienCuuKhoaHocTongHopService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NghienCuuKhoaHocTongHopDataSourceView used by the NghienCuuKhoaHocTongHopDataSource.
		/// </summary>
		protected NghienCuuKhoaHocTongHopDataSourceView NghienCuuKhoaHocTongHopView
		{
			get { return ( View as NghienCuuKhoaHocTongHopDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NghienCuuKhoaHocTongHopDataSource control invokes to retrieve data.
		/// </summary>
		public NghienCuuKhoaHocTongHopSelectMethod SelectMethod
		{
			get
			{
				NghienCuuKhoaHocTongHopSelectMethod selectMethod = NghienCuuKhoaHocTongHopSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NghienCuuKhoaHocTongHopSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NghienCuuKhoaHocTongHopDataSourceView class that is to be
		/// used by the NghienCuuKhoaHocTongHopDataSource.
		/// </summary>
		/// <returns>An instance of the NghienCuuKhoaHocTongHopDataSourceView class.</returns>
		protected override BaseDataSourceView<NghienCuuKhoaHocTongHop, NghienCuuKhoaHocTongHopKey> GetNewDataSourceView()
		{
			return new NghienCuuKhoaHocTongHopDataSourceView(this, DefaultViewName);
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
	/// Supports the NghienCuuKhoaHocTongHopDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NghienCuuKhoaHocTongHopDataSourceView : ProviderDataSourceView<NghienCuuKhoaHocTongHop, NghienCuuKhoaHocTongHopKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocTongHopDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NghienCuuKhoaHocTongHopDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NghienCuuKhoaHocTongHopDataSourceView(NghienCuuKhoaHocTongHopDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NghienCuuKhoaHocTongHopDataSource NghienCuuKhoaHocTongHopOwner
		{
			get { return Owner as NghienCuuKhoaHocTongHopDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NghienCuuKhoaHocTongHopSelectMethod SelectMethod
		{
			get { return NghienCuuKhoaHocTongHopOwner.SelectMethod; }
			set { NghienCuuKhoaHocTongHopOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NghienCuuKhoaHocTongHopService NghienCuuKhoaHocTongHopProvider
		{
			get { return Provider as NghienCuuKhoaHocTongHopService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NghienCuuKhoaHocTongHop> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NghienCuuKhoaHocTongHop> results = null;
			NghienCuuKhoaHocTongHop item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case NghienCuuKhoaHocTongHopSelectMethod.Get:
					NghienCuuKhoaHocTongHopKey entityKey  = new NghienCuuKhoaHocTongHopKey();
					entityKey.Load(values);
					item = NghienCuuKhoaHocTongHopProvider.Get(entityKey);
					results = new TList<NghienCuuKhoaHocTongHop>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NghienCuuKhoaHocTongHopSelectMethod.GetAll:
                    results = NghienCuuKhoaHocTongHopProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NghienCuuKhoaHocTongHopSelectMethod.GetPaged:
					results = NghienCuuKhoaHocTongHopProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NghienCuuKhoaHocTongHopSelectMethod.Find:
					if ( FilterParameters != null )
						results = NghienCuuKhoaHocTongHopProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NghienCuuKhoaHocTongHopProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NghienCuuKhoaHocTongHopSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = NghienCuuKhoaHocTongHopProvider.GetById(_id);
					results = new TList<NghienCuuKhoaHocTongHop>();
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
			if ( SelectMethod == NghienCuuKhoaHocTongHopSelectMethod.Get || SelectMethod == NghienCuuKhoaHocTongHopSelectMethod.GetById )
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
				NghienCuuKhoaHocTongHop entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NghienCuuKhoaHocTongHopProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<NghienCuuKhoaHocTongHop> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NghienCuuKhoaHocTongHopProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NghienCuuKhoaHocTongHopDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NghienCuuKhoaHocTongHopDataSource class.
	/// </summary>
	public class NghienCuuKhoaHocTongHopDataSourceDesigner : ProviderDataSourceDesigner<NghienCuuKhoaHocTongHop, NghienCuuKhoaHocTongHopKey>
	{
		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocTongHopDataSourceDesigner class.
		/// </summary>
		public NghienCuuKhoaHocTongHopDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NghienCuuKhoaHocTongHopSelectMethod SelectMethod
		{
			get { return ((NghienCuuKhoaHocTongHopDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NghienCuuKhoaHocTongHopDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NghienCuuKhoaHocTongHopDataSourceActionList

	/// <summary>
	/// Supports the NghienCuuKhoaHocTongHopDataSourceDesigner class.
	/// </summary>
	internal class NghienCuuKhoaHocTongHopDataSourceActionList : DesignerActionList
	{
		private NghienCuuKhoaHocTongHopDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocTongHopDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NghienCuuKhoaHocTongHopDataSourceActionList(NghienCuuKhoaHocTongHopDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NghienCuuKhoaHocTongHopSelectMethod SelectMethod
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

	#endregion NghienCuuKhoaHocTongHopDataSourceActionList
	
	#endregion NghienCuuKhoaHocTongHopDataSourceDesigner
	
	#region NghienCuuKhoaHocTongHopSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NghienCuuKhoaHocTongHopDataSource.SelectMethod property.
	/// </summary>
	public enum NghienCuuKhoaHocTongHopSelectMethod
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
	
	#endregion NghienCuuKhoaHocTongHopSelectMethod

	#region NghienCuuKhoaHocTongHopFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHocTongHop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhoaHocTongHopFilter : SqlFilter<NghienCuuKhoaHocTongHopColumn>
	{
	}
	
	#endregion NghienCuuKhoaHocTongHopFilter

	#region NghienCuuKhoaHocTongHopExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHocTongHop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhoaHocTongHopExpressionBuilder : SqlExpressionBuilder<NghienCuuKhoaHocTongHopColumn>
	{
	}
	
	#endregion NghienCuuKhoaHocTongHopExpressionBuilder	

	#region NghienCuuKhoaHocTongHopProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NghienCuuKhoaHocTongHopChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHocTongHop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhoaHocTongHopProperty : ChildEntityProperty<NghienCuuKhoaHocTongHopChildEntityTypes>
	{
	}
	
	#endregion NghienCuuKhoaHocTongHopProperty
}

