package javase.swing.Jtable;

//Link to the Code:
//http://www.java2s.com/Tutorial/Java/0240__Swing/CreatingaJTablewithrowsofvariableheight.htm

//In this Example it is suggested to use the line:

//table.setRowHeight(row, getPreferredSize().height + row * 10);

//to set the variable Row height in a Cell of a JTable.
//This works so far; however, this call triggers a new Layout of the table 
//and causes the CellRenderer to render this Cell again. So this code 
//creates a loop.

//I found a snippet where this is solved by testing, if the preferredSize 
//of the component + the offset is equal to the height of the row. If it 
//is equal, the new RowHeight won't be set and the call will be skipped.
//Examplecode:

//int offset = row * 10;
//if (getPreferredSize().height+offset != table.getRowHeight(row)) {
//            table.setRowHeight(row,  getPreferredSize().height +offset);
//}

//best regards
//Matthias Bonora (mat.bonora AT gmail.com)

import java.awt.Component;

import javax.swing.BorderFactory;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.UIManager;
import javax.swing.table.AbstractTableModel;
import javax.swing.table.TableCellRenderer;

public class Main {

	public static void main(String[] argv) {

		JFrame demoFrame = new JFrame("Variable Row Height Table Demo");

		StringTableModel imageTableModel = new StringTableModel();

		JTable imageTable = new JTable(imageTableModel);
		imageTable.getColumnModel().getColumn(0).setCellRenderer(new VariableRowHeightRenderer());

		demoFrame.getContentPane().add(new JScrollPane(imageTable));

		demoFrame.pack();
		demoFrame.setVisible(true);
	}
}

class VariableRowHeightRenderer extends JLabel implements TableCellRenderer {
	public VariableRowHeightRenderer() {
		super();
		setOpaque(true);
		setHorizontalAlignment(JLabel.CENTER);
	}

	public Component getTableCellRendererComponent(JTable table, Object value, boolean isSelected, boolean hasFocus, int row, int column) {
		if (isSelected) {
			setBackground(UIManager.getColor("Table.selectionBackground"));
		}

		if (hasFocus) {
			setBorder(UIManager.getBorder("Table.focusCellHighlightBorder"));

			if (table.isCellEditable(row, column)) {
				super.setForeground(UIManager.getColor("Table.focusCellForeground"));
				super.setBackground(UIManager.getColor("Table.focusCellBackground"));
			}
		} else {
			setBorder(BorderFactory.createEmptyBorder(1, 1, 1, 1));
		}
		setText((String) (value));
		table.setRowHeight(row, getPreferredSize().height + row * 10);
		return this;
	}
}

class StringTableModel extends AbstractTableModel {
	public static final int IMG_COL = 0;

	public String[] m_colNames = { "Variable Dimension" };

	public Class[] m_colTypes = { String.class };

	public StringTableModel() {
		super();

	}

	public int getColumnCount() {
		return m_colNames.length;
	}

	public int getRowCount() {
		return 3;
	}

	public String getColumnName(int col) {
		return "" + col;
	}

	public Object getValueAt(int row, int col) {
		return "aa";
	}
}