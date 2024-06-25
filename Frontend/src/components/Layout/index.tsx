import { GridContainer } from './styles';

import MainHeader from '../MainHeader';
import Aside from '../Aside';
import Content from '../Content';

const Layout = () => {
  return (
    <GridContainer>
      <MainHeader />
      <Aside />
      <Content />
    </GridContainer>
  );
};

export default Layout;
