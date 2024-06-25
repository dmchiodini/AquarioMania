import 'styled-components';

declare module 'styled-components' {
  export interface DefaultTheme {
    title: string;

    colors: {
      lighter: string;
      light: string;
      main: string;
      dark: string;
      darker: string;

      white: string;
      black: string;
      gray: string;

      success: string;
      info: string;
      warning: string;
      error: string;
    };
  }
}
