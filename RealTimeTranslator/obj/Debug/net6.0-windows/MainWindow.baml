   M S B A M L   `   `   `  ����  RealTimeTranslator#    RealTimeTranslator.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Real-Time Translator��5   	   $	��350��6&   $	��525��63   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0,0,0,10q�6;   .+�5      �� -   5         ��Name$ SourceLanguage��5      $	��100��6/   $��0,0,10,0q�6;   �� 5      -   5        $ TargetLanguage��5      $	��100��6/   5      �� 5   
   $��1��6   $��Enter text to translate:��6!   $��0,0,0,5q�6A   �� 5   
   -   5         ��Name$ 	InputText��5      $��1��6%   " �� VerticalScrollBarVisibility$
 Auto=�62    �� TextWrapping$
 Wrap=�6U    �� AcceptsReturn$
 True��6i   �� 5   
   $��2��6   $��Translated text:��6!   $��0,10,0,5q�69   �� 5   
   -   5        $ TranslatedText��5      $��2��6*   $
 Auto=�67   $
 Wrap=�6Z   $
 True��6n    �� 
IsReadOnly$
 True��6�   �� 5   
   $��3��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5      �� -   5        $��	Translate��5      $��75��6)   64   �� 5      -   5        $
��Copy��5      $��75��6$   $��10,0,0,0q�6/   6A   5      5      5      